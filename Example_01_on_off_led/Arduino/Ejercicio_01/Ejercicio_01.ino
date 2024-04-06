int ledPin = 13;
int dato;
String request = String(5) 

void setup() {
  // put your setup code here, to run once:
  pinMode(ledPin,OUTPUT);
  Serial.begin(9600); 
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()){
    dato = Serial.read();

    if(dato == '1'){
      digitalWrite(ledPin,HIGH);
    }
    if (dato == '0'){
      digitalWrite(ledPin,LOW);
    }
  }

}
