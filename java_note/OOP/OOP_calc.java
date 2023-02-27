package OOP;
class Calculator {
  
     // Class fields
     private double num1;
     private double num2;
   
     // Default Constructor
     public Calculator(double num1, double num2) {
       this.num1 = num1;
       this.num2 = num2;
     }
   
     // Addition Method
     double add() {
       return this.num1 + this.num2;
     }
   
     // Subtraction Method
     double subtract() {
       return this.num2 - this.num1;
     }
   
     // Multiplication Method
     double multiply() {
       return this.num1 * this.num2;
     }
   
     // Divison Method
     double divide() {
       return this.num2 / this.num1;
     }
     
   }
   
   class OOP_calc {
   
     public static void main(String args[]) {
       Calculator obj = new Calculator(10, 94);
   
       System.out.println(obj.add());
       System.out.println(obj.subtract());
       System.out.println(obj.multiply());
       System.out.println(obj.divide());
     }
   
   }
