
#define ir1 10
#define ir2 9

void setup() {
  Serial.begin(9600);

  pinMode(ir1, INPUT);
  pinMode(ir2, INPUT);
}

void loop() {
  Serial.print(digitalRead(ir1));
  Serial.print(" | ");
  Serial.println(digitalRead(ir2));

  delay(500);
}