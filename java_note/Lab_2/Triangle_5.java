public class Triangle_5 {
     public static void main(String[] args) {
          int[][] a = {
                    { 0 },
                    { 2, 4 },
                    { 6, 8, 10 },
                    { 12, 14, 16, 18 },
                    { 20, 22, 24, 26, 28 },
          };
          for (int i = 0; i < a.length; i++) {
               for (int j = 0; j < a[i].length; j++) {
                    System.out.print(a[i][j] + " ");
               }
               System.out.println();
          }
     }
}
