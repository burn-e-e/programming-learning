import java.util.*;
public class Title_4 {
     public static void main(String[] args) {
          String[] title = { "Mr", "Mrs", "Ms" };
          Scanner scan = new Scanner(System.in);
          System.out.print("Enter your name: ");
          String name = scan.nextLine();
          scan.close();
          for (int i = 0; i < title.length; i++) {
               System.out.println(title[i] + " " + name);
          }
     }
}
