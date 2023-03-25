public class bd_11 {
     public static void main(String[] args) {
          int[][] a = new int[4][4];
          int sum_diagonal = 0;
          int reverse_diagonal = 0;
          int[] massive = new int[4];
          for (int i = 0; i < a.length; i++) {
               System.out.println();
               for (int j = 0; j < a[i].length; j++) {
                    a[i][j] = (int) (Math.random() * 10);
                    if (i == j) {
                         sum_diagonal += a[i][j];
                         massive[i] = a[i][j];
                    }
                    if ((i + j) == (a.length - 1)) {
                         reverse_diagonal += a[i][j];
                    }
                    System.out.print(a[i][j] + " ");
               }
          }

          System.out.println();
          System.out.println("Sum of the diagonal: " + sum_diagonal);
          System.out.println("Sum of the reverse diagonal: " + reverse_diagonal);
          for (int i = 0; i < massive.length; i++) {
               System.out.println(massive[i] + " ");
          }
     }
}
