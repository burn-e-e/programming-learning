import java.util.Random;

public class bd_10 {
     public static void main(String[] args) {
          int[][] a = new int[4][4];
          Random rand = new Random();
          int odd = 0;
          int even = 0;
          for (int i = 0; i < a.length; i++) {
               System.out.println(" ");
               for (int j = 0; j < a[i].length; j++) {
                    a[i][j] = rand.nextInt(20);
                    System.out.print(a[i][j] + " ");
                    if (a[i][j] % 2 == 0 && a[i][j] > 10) {
                         odd += a[i][j];
                    } else {
                         even += a[i][j];
                    }
               }
          }
          System.out.println();
          System.out.println("Odd and less than 10 numbers: "+odd);
          System.out.println("Even and greater than 10 numbers: "+even);
     }
}
