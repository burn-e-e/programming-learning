package Lab_5_2;

import Lab_5_Box.*;

public class Main {
     public static void main(String[] args) {
          Student s1 = new Student();
          s1.setName("Burnee");
          // System.out.println(s1.getName());
          Teacher r1 = new Teacher();
          r1.setName("Tungalag");
          r1.display(s1);
     }
}
