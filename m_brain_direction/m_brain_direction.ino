#include "WiFi.h"
#include <Brain.h>

const char* ssid = "Visitors";
const char* password =  "";
Brain brain(Serial);
int attValue =0;
int incomingByte = 0;


IPAddress server(10,72,67,117); // IP address of the computer running Unity
const int port = 8080;
WiFiClient client;

void setup() {
    Serial.begin(115200);
    WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }

  Serial.println("Connected to WiFi");

  if (client.connect(server, port)) {
    Serial.println(client.remoteIP());
    Serial.println("Connected to server");
  } else {
    Serial.println("Connection to failed");
  }
}

void loop() {
  // Serial.print("looping...");
  // put your main code here, to run repeatedly:
   // String data = "Hello from Arduino";
   if (brain.update()) {
    
    attValue = brain.readMeditation();
Serial.println(attValue);

    if(brain.readSignalQuality() == 0) {
        
        
        if( attValue < 30) {
          client.println("S"); // go backward
        }
        if( attValue < 50 && attValue >= 30) {
          client.println("W"); // go forward
        }
        if(attValue < 70 && attValue >= 50) {
          client.println("D"); // go to right
        }
        if( attValue >= 70) {
          client.println("A"); // go to left
        }
      }
      else {
        client.println("S");
      } 
  }

  delay(1000);
}
