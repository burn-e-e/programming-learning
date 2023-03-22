package Lab_8_2;
public class Student extends Person{
     private int gpa;
     private String majorName;
     Student(String name, int age, int gpa, String majorName) {
          super(name, age);
          this.gpa = gpa;
          this.majorName = majorName;
     }
     void show() {
          super.show();
          System.out.println("GPA: " + gpa + " Major: " + majorName);
     }
}
