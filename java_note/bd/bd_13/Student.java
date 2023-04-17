package bd_13;

public class Student {
     private String studentName;
     private int studentAge;
     private int studentGpa;
     private String studentCode;
     private Teacher teacher;
     Student(String studentName, int studentAge, int studentGpa, String studentCode) {
          this.studentName = studentName;
          this.studentAge = studentAge;
          this.studentGpa = studentGpa;
          this.studentCode = studentCode;
     }
     void setTeacher(Teacher teacher){
          this.teacher = teacher;
     }
     void setName(String name){
          this.studentName = name;
     }
     String getName(){
          return studentName;
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
          teacher.display();
     }

     void lastDigit() {
          System.out.println(studentCode.charAt(studentCode.length() - 3));
     }
}
