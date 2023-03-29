package Lab_9;

public class Vehicle {
     private String Manufacturer, Vehicleld;
     Vehicle(String name, String num){
          Manufacturer = name;
          Vehicleld = num;
     }
     void display(){
          System.out.println("Manufacturer: " + Manufacturer);
          System.out.println("Vehicleld: " + Vehicleld);
     }
}
