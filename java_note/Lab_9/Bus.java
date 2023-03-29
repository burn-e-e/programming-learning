package Lab_9;

public class Bus extends Vehicle{
     private int NumOfSeats, NumOfWheels;
     Bus(String name, String vehicle, int seats,int wheels){
          super(name, vehicle);
          NumOfSeats = seats;
          NumOfWheels = wheels;
     }
     void display(){
          super.display();
          System.out.println("Number of Seats: " + NumOfSeats);
          System.out.println("Number of Wheels: " + NumOfWheels);
     }
}
