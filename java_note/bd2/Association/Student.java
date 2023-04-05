package bd2.Association;
import java.util.ArrayList;
public class Student {
     private String name;
     private int code;
     private ArrayList<Teacher> teachers;
   
     public Student(String name, int code) {
       this.name = name;
       this.code = code;
       this.teachers = new ArrayList<>();
     }
   
     public void addTeacher(Teacher teacher) {
       if (teachers.size() < 5) {
         teachers.add(teacher);
       }
       else {
         System.out.println("This student has reached the maximum number of teachers.");
       }
     }
   
     public void printTeachers() {
       System.out.println("Teachers teaching " + name + ":");
       for (Teacher teacher : teachers) {
         System.out.println(teacher);
       }
     }
   
     @Override
     public String toString() {
       return name + " (" + code + ")";
     }
   }
   
