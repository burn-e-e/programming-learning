public class Test2 {
     public static void main(String[] args) {
          int a[];
          a = new int[10];
          a[3] = 6;
          System.out.print(a[3] + "\n");
          for (int i = 0; i < 10; i++) {
               System.out.print(a[i] + " ");
          }
          System.out.println();
          System.out.println();
          int arr[][];
          arr = new int[5][5];
          arr[2][3] = 6;
          System.out.print(arr[2][3] + "\n");
          for (int i = 0; i < 5; i++) {
               for (int j = 0; j < 5; j++) {
                    System.out.print(arr[i][j] + " ");
               }
               System.out.print("\n");
          }
     }
}