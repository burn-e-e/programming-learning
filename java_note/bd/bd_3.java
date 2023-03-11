package bd;

public class bd_3 {
     public static int fac(int n) {
          if (n <= 1)
               return 1;
          else
               return (n * fac(n - 1));
     }

     public static void main() {
          System.out.println(fac(5));
     }
}