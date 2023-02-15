package Examples;
// Square Sum
class SquareSum {
     private double a,b,c;

     // Method to sum the squares of three numbers
     double squareSum(double num1, double num2, double num3) {
          double sum = 0;
          
          this.a = num1;
          this.b = num2;
          this.c = num3;
          sum = (a*a) + (b*b) + (c*c);

          // Write your code here

          return sum;
     }

}    

public class Squaresum {
     public static void main(String[] args) {
          SquareSum ss = new SquareSum();
          System.out.println(ss.squareSum(1, 2, 3));
     }
}
