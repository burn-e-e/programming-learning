package Lab_8_2;

public class Teacher extends Person{
     String subject;
     int salary;
     Teacher(String name, int age, String subject, int salary){
          super(name, age);
          this.subject = subject;
          this.salary = salary;
     }
}
