import java.util.*;

public class Program {
     public static void main(String[] args) {
          String ner = new String();
          // int too;
          String dun = " ";
          Scanner scan = new Scanner(System.in);
          System.out.println("Ta neree oruulna uu?");
          ner = scan.nextLine();
          System.out.println("Sain baina uu? " + ner);
          System.out.println("Ta dungee oruulna uu!");
          int too = scan.nextInt() ;
          scan.close();
          if (too >= 96) {
               dun = "A+";
          } else if (too >= 91 && too <= 95) {
               dun = "A-";
          } else if (too >= 88 && too >= 90) {
               dun = "B+";
          } else if (too >= 84 && too >= 87) {
               dun = "B";
          } else if (too >= 81 && too >= 83) {
               dun = "B-";
          } else if (too >= 78 && too >= 80) {
               dun = "C+";
          } else if (too >= 74 && too >= 77) {
               dun = "C";
          } else if (too >= 71 && too >= 73) {
               dun = "C-";
          } else if (too >= 68 && too >= 70) {
               dun = "D+";
          } else if (too >= 64 && too >= 67) {
               dun = "D";
          } else if (too >= 60 && too >= 63) {
               dun = "D-";
          } else if (too >= 0 && too >= 59) {
               dun = "F";
          }
          // System.out.println("Tanii dun: "+dun);
          switch (too / 10) {

               case 10:
               case 9:
                    System.out.print("Grade: A");
                    break;

               case 8:
                    System.out.print("Grade: B");
                    break;

               case 7:
                    System.out.print("Grade: C");
                    break;

               case 6:
                    System.out.print("Grade: D");
                    break;

               case 5:
                    System.out.print("Grade: E");
                    break;

               default:
                    System.out.print("Grade: F");
                    break;

          }
     }
}
