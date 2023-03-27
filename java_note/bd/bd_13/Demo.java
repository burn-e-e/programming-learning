package bd_13;

import java.util.Scanner;

public class Demo {
     public static void main(String[] args) {
          Student[] students = new Student[5];
          students[0] = new Student("Ivan", 20, 4, "Software Programming");
          students[1] = new Student("Burentugs", 19, 4, "Software Programming");
          students[2] = new Student("Bat", 22, 4, "Software Programming");
          students[3] = new Student("Erdene", 23, 4, "Software Programming");
          students[4] = new Student("Bolor", 24, 4, "Software Programming");
          Scanner sc = new Scanner(System.in);
          for (int i = 0; students.length > i; i++) {
               students[i].setName(sc.nextLine());
               for (int j = 0; students.length > j; j++) {
                    if (students[i].equals(students[j].getName())) {
                         students[i].changeGpa(sc.nextInt());
                    }
               }
               System.out.println(students[i].toString());
          }

     }
}
