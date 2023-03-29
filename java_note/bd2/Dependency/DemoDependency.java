package bd2.Dependency;

public class DemoDependency {
     public static void main(String[] args) {
          Calculator c = new Calculator(new MathOperations(), 10, 20);
          c.showSum();
          c.showMul();
     }
}
