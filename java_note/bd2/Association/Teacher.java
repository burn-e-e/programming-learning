package bd2.Association;

import java.util.ArrayList;

public class Teacher {
     private String name;
     private String major;
     private ArrayList<Student> students;

     public Teacher(String name, String major) {
          this.name = name;
          this.major = major;
          this.students = new ArrayList<>();
          
     }

     public void setStudents(Student student) {
          if (students.size() < 20) {
               students.add(student);
               student.addTeacher(this);
          } else {
               System.out.println("This teacher has reached the maximum number of students.");
          }
     }

     public void printStudents() {
          System.out.println("Students learning from " + name + ":");
          for (Student student : students) {
               System.out.println(student);
          }
     }

     @Override
     public String toString() {
          return name + " (" + major + ")";
     }
}
