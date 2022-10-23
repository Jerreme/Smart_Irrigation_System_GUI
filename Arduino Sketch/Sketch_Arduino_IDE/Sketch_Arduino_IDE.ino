/* Seed Growing Device Project
   - an smart plant watering system that grows seed and/or small plants.

   Group Members:
    Jerreme De Torres
    Jayvie Balili
    Nathaniel Valenzuela
    John Lloyd Gabriel
    Leo Marc Boco
    John Dominick Lariosa
*/


#include <Arduino.h>
#include <Sensors.h>
#include <Functions.h>

//Define Pins
#define servo_pin 3
#define relayPump_pin 4
#define relayLED_pin 5

#define ir1_pin 10
#define ir2_pin 9

#define moist1_pin 13
#define moist2_pin 12

#define ldr_pin A0
#define volt_pin A1
#define dht_pin A2
#define buzzer_pin A3


/* Object for our Sensor Library */
Sensors S;
/* Object for our Function Library */
Functions F = Functions(servo_pin, buzzer_pin, relayPump_pin, relayLED_pin);

int count = 0;
int battery = 0;

int sun;
int temp;
int humid;
double volt;

bool analytic = false;
bool trig = false;

/* Over all Data */
String OVERALL_DATA = "";
int time_delay = 200;

/* Triggered when VB GUI is Connected */
void VB_CONNECTED() {
  time_delay = 1000;  // set to 1sec loop delay, to be synchrounous with VB GUI
}

/* PS: Voltage reading is quite defferent WHen arduino board is powered view USB */
/* NOTE: If VB GUI is not present and/or Arduino Board is powered via battery.
   Reboot the Devie to set back to it's Standalone Values.*/

void setup() {

  /* Pins Configuration */
  pinMode(servo_pin, OUTPUT);
  pinMode(relayPump_pin, OUTPUT);
  pinMode(relayLED_pin, OUTPUT);

  pinMode(ir1_pin, INPUT);
  pinMode(ir2_pin, INPUT);

  pinMode(moist1_pin, INPUT);
  pinMode(moist2_pin, INPUT);

  pinMode(ldr_pin, INPUT);
  pinMode(volt_pin, INPUT);
  pinMode(dht_pin, INPUT);
  pinMode(buzzer_pin, OUTPUT);


  /* This allows us to communicate to VB GUI using Serial Communication
     Baud rate is must be 9600 */
  Serial.begin(9600);

  /* Trap Sketch if Device is not yet powered */
  while (S.readVoltage(volt_pin) < 1) {
    Serial.println("Device is not yet powered! [Delegate]");  // Continue Alerting VB GUI
    delay(10000);                                             // wait 10 seconds to warn the VB again
  }
  /* [1] The Only solution is to Turn on the Battery FIRST to powered the device
     [2] Then Connect the Arduino Board via Arduino Cable to the USB Port of the Computer */


  Serial.println("Hi VB");
  F.START();  // Boot for 3 Seconds then beep
  Serial.println("Booted successfully");
  Serial.flush();  // Waits for the transmission of outgoing serial data to complete.
  delay(100);      // Stabilize transmission of data

  if (Serial.available()) {
    if (char(Serial.read()) == '?') {
      VB_CONNECTED();
    }
  }
}

void loop() {
  OVERALL_DATA = "";  // --> Reset OVERALL_DATA

  if (Serial.available()) {
    char c = Serial.read();

    switch (c) {
      case 'P':
        F.pumpWater("Plant 1");
        // Serial.print("Plant 1 Done :)");  //--> Send Feedback to VB
        break;
      case 'p':
        F.pumpWater("Plant 2");
        // Serial.print("Plant 2 Done :)"); //--> Send Feedback to VB
        break;

      case 'L':
        digitalWrite(relayLED_pin, HIGH);
        break;
      case 'l':
        digitalWrite(relayLED_pin, LOW);
        break;

      case 'U':
        digitalWrite(F.pumpPin, HIGH);
        break;
      case 'u':
        digitalWrite(F.pumpPin, LOW);
        break;

      case '?':
        VB_CONNECTED();
        break;

      default:
        break;
    }
  }

  // -Read Sensors And or Gather Information-

  volt = S.readVoltage(volt_pin);
  sun = S.readSun(ldr_pin);
  temp = S.readTemp(dht_pin);
  humid = S.readHumidity(dht_pin);
  battery = F.getBattPercentage();

  if (volt > 4.2) {
    volt = 4.2;
  } else if (volt < 3.0) {
    volt = 3.0;
  }

  // ------------Display Data------------------
  if (!analytic) {
    //Word Display
    F.display("S: " + F.convert_sun(sun), 0, 0);
    F.display("T: " + F.convert_temp(temp), 9, 0);
    F.display("H: " + F.convert_humidity(humid), 0, 1);
    F.display("V: " + F.convert_voltage(volt) + "% ", 9, 1);

  } else {
    //Number Display
    F.display("S: " + String(F.getSunVal(sun)) + "%   ", 0, 0);
    F.display("T: " + String(temp) + "C ", 9, 0);
    F.display("H: " + String(humid) + "%   ", 0, 1);
    F.display("V: " + String(volt), 9, 1);
  }

  //Append Info to OVERALL_DATA --> Must be send the analytic val
  OVERALL_DATA += "H" + String(humid) + "\n";
  OVERALL_DATA += "T" + String(temp) + "\n";
  OVERALL_DATA += "S" + String(F.getSunVal(sun)) + "\n";
  OVERALL_DATA += "B" + F.convert_voltage(volt) + "\n";
  OVERALL_DATA += "V" + String(volt) + "\n";

  Serial.println(OVERALL_DATA);  //--> Send Data to VB
  Serial.flush();

  // -Low Battery Alarm-
  // if(battery == 30) {     // Alarm if battery dip to 30%
  //   F.buzzer("Low Battery");
  // }

  // -Auto Water the plant-
  if (S.readMoisture(moist1_pin)) {  // True if the soil is Dry
    if (!S.readIR(ir1_pin)) {        // True if pot is present
      F.pumpWater("Plant 1");
    }
  }
  if (S.readMoisture(moist2_pin)) {  // True if the soil is Dry
    if (!S.readIR(ir2_pin)) {        // True if pot is present
      F.pumpWater("Plant 2");
    }
  }

  // -Swap Display-
  if (count >= 20) {  // Swap Displays every 5 seconds(250ms*20)
    if (analytic)
      analytic = false;
    else
      analytic = true;

    count = 0;  // Reset count
    F.clearDisplay();
  }
  count++;
  delay(time_delay);  //--> Delay must be the same ar VB GUI
}