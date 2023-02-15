package Examples;
import java.util.Scanner;

public class Self {
     public static void main(String[] args) {

          Scanner sc = new Scanner(System.in);
          System.out.println("What is your name? ");
          String name = sc.nextLine();
          System.out.println("Your Gender?");
          char gender = sc.next().charAt(0);
          System.out.println("Your Age?");
          int age = sc.nextInt();
          System.out.println("Your Phonenumber?");
          long mobileNo = sc.nextLong();
          System.out.println("Your GPA?");
          double gpa = sc.nextDouble();
          sc.close();
          System.out.println("Name: " + name);
          System.out.println("Gender: " + gender);
          System.out.println("Age: " + age);
          System.out.println("Mobile Number: " + mobileNo);
          System.out.println("CGPA: " + gpa);
     }
}