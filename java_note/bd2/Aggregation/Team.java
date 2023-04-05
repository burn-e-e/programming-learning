package bd2.Aggregation;

import java.util.ArrayList;

public class Team {
     private String teamName;
     private ArrayList<Student> students;
   
     public Team(String teamName) {
       this.teamName = teamName;
       this.students = new ArrayList<>();
     }
   
     public void addStudent(Student student) {
       students.add(student);
     }
   
     public void show() {
       System.out.println("Team name: " + teamName);
       for (Student student : students) {
         student.print();
       }
     }
   }
