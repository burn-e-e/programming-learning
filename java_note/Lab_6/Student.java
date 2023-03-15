package Lab_6;

public class Student {
     private int age;
     private String name;
     private double gpa;

     Student(String b,int a,  double c) {
          this.age = a;
          this.name = b;
          this.gpa = c;
     }
     String getName(){
          return name;
     }
     void charName(){
          int a = name.length();
          for(int i = 0; i < a; i++){
               System.out.println(name.charAt(i));
          }
     }
     String display(){
          return name + "" + age + "" + gpa;
     } 
}
