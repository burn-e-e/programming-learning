package HackerRank;
import java.util.*;
public class Java_if_else {
     private static final Scanner scan = new Scanner(System.in);
     public static void main(String[] args) {
          int n = scan.nextInt();
          if(n%2==1 || (n>=6 && n<=20)) {
               System.out.println("Weird");
          } else {
               System.out.println("Not Weird");
          }
          scan.close();
     }
}
