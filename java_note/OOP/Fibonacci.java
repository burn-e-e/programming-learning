package OOP;

public class Fibonacci {
     public static long fib(long n) {
          if (n <= 1) {
               return n;
          } else {
               return fib(n - 1) + fib(n - 2);
          }
     }
     public static void main(String[] args) {
          System.out.println(fib(3));
     }
}
