package OOP;
class Calculator {
     public double product(double x, double y) {
       return x * y;
     }
     public double product(double x, double y, double z) {
       return x * y * z;
     }
     public int product(int x, int y){
       return x * y;
     }
   
   }
   
   class Method_Overloading extends Calculator{
     
     public static void  main(String args[]) {
       Calculator cal = new Calculator();
       
       double x = 10;
       double y = 20;
       double z = 5;
       
       int a = 12;
       int b = 4;
       
       System.out.println(cal.product(x, y));
       System.out.println(cal.product(x, y, z));
       System.out.println(cal.product(a, b));
     }
     
   }