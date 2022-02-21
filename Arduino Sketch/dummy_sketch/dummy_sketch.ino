// ------- Sketch Dummy for Arduimo ----------

int humidity = 10;
int temperature = 15;
int sun = 2;
int batt = 0;
float volt = 40.2;

String OVERALL_DATA = "";

void setup(){
  Serial.begin(9600);
}

void loop(){
  OVERALL_DATA = "";
//  Serial.print("H");
//  Serial.println(humidity);
  OVERALL_DATA += "H" + String(humidity) + "\n";
  
//  Serial.print("T");
//  Serial.println(temperature);
  OVERALL_DATA += "T" + String(temperature) + "\n";
  
//  Serial.print("S");
//  Serial.println(sun);
  OVERALL_DATA += "S" + String(sun) + "\n";

//  Serial.print("B");
//  Serial.println(batt);
  OVERALL_DATA += "B" + String(batt) + "\n";
  
//  Serial.print("V");
//  Serial.println(volt);
  OVERALL_DATA += "V" + String(volt) + "\n";

  if (Serial.available()) {
    char c = Serial.read();

    if (c == 'P') {
      delay(2000);
      Serial.println("Plant 1 Done :)");
    }else if (c == 'p') {
      delay(2000);
      Serial.println("Plant 2 Done :)");
    }
  }else { 
    Serial.println(OVERALL_DATA);
    
    humidity++;
    temperature++;
    sun+=10;
    batt+= 10;
    volt += .25;
  }
  
  
  delay(1000); //--> The value is the same as the interval value in the TimerSerial in the VB application
}
