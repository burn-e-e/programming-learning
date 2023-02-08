import java.util.*;

public class Kass_3 {
     public static void main(String[] args) {
          double water = 0.59, soda = 1.29, chips = 2.00, cookie = 3.50, all;

          System.out.println("Water_bottle = " + water + "$");
          System.out.println("Soda_bottle = " + soda + "$");
          System.out.println("Fried_chips = " + chips + "$");
          System.out.println("Cookie_box = " + cookie + "$");
          double[] data = new double[4];
          Scanner scan = new Scanner(System.in);
          for (int i = 0; i < data.length; i++) {
               data[i] = scan.nextInt();
          }
          scan.close();
          water *= data[0];
          soda *= data[1];
          chips *= data[2];
          cookie *= data[3];
          System.out.println("-------------------------------------------------------------");
          System.out.println("Water_bottle = " + water + "$");
          System.out.println("Soda_bottle = " + soda + "$");
          System.out.println("Fried_chips = " + chips + "$");
          System.out.println("Cookie_box = " + cookie + "$");
          System.out.println("-------------------------------------------------------------");
          all = water + soda + chips + cookie;
          System.out.println("All = " + all + "$");
          System.out.println("-------------------------------------------------------------");
          int ten_dollar, dollar;
          double quarter, penny;
          ten_dollar = (int) all / 10;
          dollar = (int) all - ten_dollar * 10;
          quarter = (double) ((all - ten_dollar * 10 - dollar) / 0.25);
          if (quarter < 1) {
               quarter = 0;
          }
          penny = (double) (all - ten_dollar * 10 - dollar - quarter);
          penny *= 100;
          System.out.println("Ten_dollar = " + ten_dollar);
          System.out.println("Dollar = " + dollar);
          System.out.println("Quarter = " + quarter);
          System.out.println("Penny = " + (int) penny);
          System.out.println("-------------------------------------------------------------");

     }
}
