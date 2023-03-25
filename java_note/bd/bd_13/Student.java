package bd_13;

public class Student {
     private String studentName;
     private int studentAge;
     private int studentGpa;
     private String studentCode;

     Student(String studentName, int studentAge, int studentGpa, String studentCode) {
          this.studentName = studentName;
          this.studentAge = studentAge;
          this.studentGpa = studentGpa;
          this.studentCode = studentCode;
     }

     public String toString() {
          return "Name: " + studentName + " Age: " + studentAge + " GPA: " + studentGpa + " Code: " + studentCode;
     }

     void changeGpa(int gpa) {
          this.studentGpa = gpa;
     }

     void capsName() {
          this.studentName = studentName.toUpperCase();
     }

     void nameLength() {
          System.out.println(studentName.length());
     }

     void lastDigit() {
          System.out.println(studentCode.charAt(studentCode.length() - 3));
     }
}
