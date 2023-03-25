package bd_13;
import java.util.Scanner;

public class Demo {
     public static void main(String[] args) {
          Student[] students = new Student[5];
          for (int i = 0; i < students.length; i++) {
               students[i] = new Student("Student " + i, 20, 3, "123456789");
               System.out.println(students[i]);
          }
     }
}
