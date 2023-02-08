import java.util.*;

public class Exchange_1 {
     public static void main(String[] args) {
          int tug, usd;
          double hansh = 3496.98, exchange=0;
          Scanner scan = new Scanner(System.in);
          System.out.print("Enter the amount of tug: ");
          tug = scan.nextInt();
          usd = (int) (tug / hansh);
          exchange = (double)(tug/hansh);
          exchange -= (double)(usd);
          exchange *= 3496.98;
          System.out.println("The amount of usd is " + usd);
          System.out.println("The amount of exchange is " + exchange +" tug");
          scan.close();
     }
}
