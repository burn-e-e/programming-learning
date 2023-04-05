package bd2.Aggregation;

public class Student {
     private String name;
     private String code;
   
     public Student(String name, String code) {
       this.name = name;
       this.code = code;
     }
   
     public void print() {
       System.out.println("Student name: " + name + ", code: " + code);
     }
   }
