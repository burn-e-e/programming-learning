package Lab_12;

public class Student {
     private String name;
     private String code;
     private double gpa;

     Student(String name, String code, double gpa) {
          this.name = name;
          this.code = code;
          this.gpa = gpa;
     }
     void show(){
          System.out.println("Name: "+name+" Code: "+code+" Gpa: "+gpa);
          System.out.println("Zail");
     }
}
