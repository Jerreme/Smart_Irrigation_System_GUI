#define moist1 A0
#define moist2 A2

#define dmoist1 13
#define dmoist2 12

void setup() {
  Serial.begin(9600);

  pinMode(dmoist1, INPUT);
  pinMode(dmoist2, INPUT);
}

void loop() {
  Serial.print(analogRead(moist1));
  Serial.print(" | ");
  Serial.println(digitalRead(dmoist1));

  delay(500);
}