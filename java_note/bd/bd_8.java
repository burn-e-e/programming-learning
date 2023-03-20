import java.util.Random;

public class bd_8 {
     public static void main(String[] args) {
          Random rand = new Random();
          int[] a = new int[10];
          byte max = 0;
          for (int i = 0; i < a.length; i++) {
               a[i] = rand.nextInt(100);
               if ((byte) (a[i]) > max) {
                    max = (byte) (a[i]);
               }
               System.out.println(i + 1 + " = " + a[i]);
          }
          System.out.println(max);
     }
}
