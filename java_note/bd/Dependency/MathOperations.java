package Dependency;

public class MathOperations {
     private int num1;
     private int num2;
     int sum(int sum1, int sum2){
          this.num1 = sum1;
          this.num2 = sum2;
          return this.num1 + this.num2;
     }
     int subtract(int subtract1, int subtract2){
          this.num1 = subtract1;
          this.num2 = subtract2;
          return this.num1 - this.num2;
     }
     int multiply(int multiply1, int multiply2){
          this.multiply1 = multiply1;
          this.multiply2 = multiply2;
          return this.multiply1 * this.multiply2;
     }
     int divide(int divide1, int divide2){
          this.divide1 = divide1;
          this.divide2 = divide2;
          return this.divide1 / this.divide2;
     }
}