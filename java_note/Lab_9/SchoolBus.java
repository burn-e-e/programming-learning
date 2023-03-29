package Lab_9;

public class SchoolBus extends Bus{
     private String schoolName;
     SchoolBus(String name, String num, int seats, int wheels, String sname){
          super(name, num, seats, wheels);
          schoolName = sname;
     }
     void display(){
          super.display();
          System.out.println("School Name: " + schoolName);
     }
}
