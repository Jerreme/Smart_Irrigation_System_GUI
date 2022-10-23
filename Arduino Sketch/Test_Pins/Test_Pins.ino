#include <DFRobot_DHT11.h>
#include <Servo.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>

#define relayPump_pin 4
#define relayLED_pin 5

#define buzzer_pin A3
#define DHT11_PIN A2

#define servo_pin 3
#define volt_pin A1
#define ldr_pin A0

DFRobot_DHT11 DHT;
Servo myservo;
LiquidCrystal_I2C lcd(0x27, 16, 2);

int i = 0;
int pos = 0;

void setup() {
  Serial.begin(9600);
  
  pinMode(relayPump_pin, OUTPUT);
  pinMode(relayLED_pin, OUTPUT);

  pinMode(buzzer_pin, OUTPUT);
  myservo.attach(servo_pin);

  pinMode(volt_pin, INPUT);
  pinMode(ldr_pin, INPUT);

  lcd.begin();
  lcd.backlight();
  lcd.clear();

  // Serial.println("Testing...");
  // delay(1000);
}

void loop() {
  // relays_test();
  // buzzer_test();
  // dht11_test();
  // servo_test();
  // lcd_test();
  readSun();
  readVoltage();

  delay(1000);
}



void relays_test() {
  digitalWrite(relayPump_pin, HIGH);
  digitalWrite(relayLED_pin, LOW);
  delay(100);
  digitalWrite(relayPump_pin, LOW);
  digitalWrite(relayLED_pin, HIGH);
  delay(100);
}

void buzzer_test() {
  for (i = 25; i < 120; i++) {
    tone(buzzer_pin, 20 * i, 200);  // Create a tone/note from 500 to 2400 Hz
    delay(20);
  }
  for (i = 120; i >= 25; i--) {
    tone(buzzer_pin, 20 * i, 200);  // Create a tone/note from 2400 Hz to 500 hz
    delay(20);
  }
}

void dht11_test() {
  DHT.read(DHT11_PIN);
  Serial.print("temp:");
  Serial.print(DHT.temperature);
  Serial.print("  humi:");
  Serial.println(DHT.humidity);
}

void servo_test() {
  for (pos = 0; pos <= 180; pos += 1) {  // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
    myservo.write(pos);  // tell servo to go to position in variable 'pos'
    delay(15);           // waits 15 ms for the servo to reach the position
  }
  for (pos = 180; pos >= 0; pos -= 1) {  // goes from 180 degrees to 0 degrees
    myservo.write(pos);                  // tell servo to go to position in variable 'pos'
    delay(15);                           // waits 15 ms for the servo to reach the position
  }
}

void lcd_test() {
  lcd.clear();
  lcd.print("Testing Display...");
  delay(1000);
  lcd.clear();
  lcd.print("Test Completed");
}

void readVoltage() {
  int read = analogRead(volt_pin);
  double voltage = map(read, 0, 1023, 0, 2500) + 0;
  voltage /= 100;
  // voltage -= 0.30;  //---> Callibration Treshold For VB [Removable]

  String txt = String(read) + " | " + String(voltage) + "v";
  Serial.println(txt);


  lcd.setCursor(0,0);
  lcd.print(txt);
}

void readSun() {  
   int sun_val = analogRead(ldr_pin);
   double inverted = double(sun_val) / 1023.0 * 100.0;
   int percentage = 100 - inverted;
   lcd.clear();
   delay(100);
   lcd.setCursor(0,1);
   lcd.print(sun_val);
   lcd.print(" | ");
   lcd.print(percentage);

   
   
}