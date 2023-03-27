package bd_13;

public class Teacher {
     private String teacherName;
     private String teacherSubject;
     private int teacherSalary;

     Teacher(String teacherName, String teacherSubject, int teacherSalary) {
          this.teacherName = teacherName;
          this.teacherSubject = teacherSubject;
          this.teacherSalary = teacherSalary;
     }

     void display() {
          System.out.println("-------------------------------");
          System.out.println("Teacher Name: " + teacherName);
          System.out.println("Teacher Subject: " + teacherSubject);
          System.out.println("Teacher Salary: " + teacherSalary);
          System.out.println("-------------------------------");
     }

     void checkSalary(int salary) {
          if (teacherSalary > salary) {
               System.out.println("Teacher's salary greater than " + salary);
          } else {
               System.out.println("Teacher's salary less than " + salary);
          }
     }

     void changeSalary(int salary) {
          this.teacherSalary = salary;
          if (teacherSalary > salary) {
               System.out.println("Teacher's salary greater than " + salary);
          } else {
               System.out.println("Teacher's salary less than " + salary);
          }

     }
}
