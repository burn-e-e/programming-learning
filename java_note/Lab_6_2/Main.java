package Lab_6_2;

public class Main {
     private String name;
     private int pay;
     private int paid;

     private static int totalPay;
     private static int totalPaid;
     private static int totalRemain;

     Main(String name, int pay, int paid) {
          this.name = name;
          this.pay = pay;
          this.paid = paid;
     }

     int totalPay() {
          return totalPay += pay;
     }

     int totalPaid() {
          return totalPaid += paid;
     }

     int totalRemain() {
          return totalRemain = totalPay - totalPaid;
     }

     void show() {
          System.out.print(name + "" + paid);
     }

     void show(int t) {
          System.out.println(pay / t);
     }

     void show(String p) {
          System.out.println(p);
          System.out.println(totalPay);
          System.out.println(totalPaid);
          System.out.println(totalRemain);
     }
}
