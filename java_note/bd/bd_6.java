import java.util.Scanner;

public class bd_6 {

     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          int num = sc.nextInt();
          long factorial = multiplyNumbers(num);
          System.out.println("Factorial of " + num + " = " + factorial);
          sc.close();
     }

     public static long multiplyNumbers(int num) {
          if (num >= 1)
               return num * multiplyNumbers(num - 1);
          else
               return 1;
     }
}