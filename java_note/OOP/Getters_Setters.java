package OOP;
class Car {
     private int speed;

     public void setSpeed(int x) {
          speed = x;
     }

     public int getSpeed() {
          return speed;
     }
}

public class Getters_Setters extends Method_Overloading{

     public static void main(String[] args) {
          Car car = new Car();
          car.setSpeed(100);
          System.out.println(car.getSpeed());
          Calculator cal = new Calculator();
          System.out.println((int)cal.product(4, 2 , 3));
          
     }
}
