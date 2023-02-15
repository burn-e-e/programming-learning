package Lab_3;

class Student {
     String name;
     int age;
     double gpa;

     Student(String n, int a, double g) {
          name = n;
          age = a;
          gpa = g;
     }

     void setName(String p) {
          name = p;
     }

     String getName() {
          return name;
     }

     void setAge(int p) {
          age = p;
     }

     int getAge() {
          return age;
     }

     void setGpa(double p) {
          gpa = p;
     }

     double getGpa() {
          return gpa;
     }
}

public class Bodlogo1 {
     public static void main(String[] args) {
          Student student1 = new Student("Bolor", 20, 3.5);
          student1.setName("Tuya");
          System.out.println(student1.getName() + " " + student1.getAge() + " " + student1.getGpa());
          Student s2 = new Student("Bolorchimeg", 19, 3.8);
          System.out.println(s2.getName() + " " + s2.getAge() + " " + s2.getGpa());
     }
}
