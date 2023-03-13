import java.util.Scanner;

class Study_before {
     int level;

     Study_before(int lvl) {
          level = lvl;
     }

     void showLevel() {
          switch (level) {
               case 1:
                    System.out.println("Pay 250,000");
                    break;
               case 2:
                    System.out.println("Pay 270,000");
                    break;
               case 3:
                    System.out.println("Pay 297,500");
                    break;
               default:
                    break;
          }
     }
}

class Never_studydied {
     int level;

     Never_studydied(int lvl) {
          level = lvl;
     }

     void showLevel() {
          switch (level) {

               case 1:
                    System.out.println("Pay 250,000");
                    break;
               case 2:
                    System.out.println("Pay 300,000");
                    break;
               case 3:
                    System.out.println("Pay 350,500");
                    break;
               default:
                    System.out.println("Enter 1 or 2 or 3");
                    break;
          }
     }
}

public class bd_2 {
     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          String question = "Which level will you study?";
          System.out.println("Have you ever studied before? Yes[1] or No[0]");
          int studied = sc.nextInt();
          int askLvl;

          if (studied == 1) {
               System.out.println(question);
               askLvl = sc.nextInt();
               Study_before myobj = new Study_before(askLvl);
               myobj.showLevel();
          }
          if (studied == 0) {
               System.out.println(question);
               askLvl = sc.nextInt();
               Never_studydied myobj = new Never_studydied(askLvl);
               myobj.showLevel();
          }
          sc.close();
     }
}
