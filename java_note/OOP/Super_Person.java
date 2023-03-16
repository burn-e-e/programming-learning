package OOP;

public class Super_Person {
     String name;
     int age;
     Super_Person(String name, int age){
          this.name = name;
          this.age = age;
     }
     public String toString(){
          return this.name + "\n" + this.age + "\n";
     }
}
