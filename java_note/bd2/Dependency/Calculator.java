package bd2.Dependency;

public class Calculator {
     int a,b;
     MathOperations object1 = new MathOperations();
     Calculator(MathOperations obj, int a, int b){
          this.object1 = obj;
          this.a = a;
          this.b = b;
     }
     public void setA(int a) {
          this.a = a;
     }
     public void setB(int b) {
          this.b = b;
     }
     void showSum(){
          System.out.println("Sum is: " + object1.sum(a, b));
     }
     void showSub(){
          System.out.println("Sub is: " + object1.sub(a, b));
     }
     void showMul(){
          System.out.println("Mul is: " + object1.mul(a, b));
     }
     void showDiv(){
          System.out.println("Div is: " + object1.div(a, b));
     }
}
