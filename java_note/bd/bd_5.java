import java.util.Scanner;

public class bd_5 {
     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          char[] character = new char[10];
          for (int i = 0; i < character.length; i++) {
               character[i] = sc.next().charAt(0);
               if (character[i] == 'a') {
                    System.out.print(i + 1);
                    break;
               }
               System.out.print(character);
          }
          sc.close();
     }
}
