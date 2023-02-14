public class rand_massive {
     public static void main(String[] args) {
          int a[] = new int[10];
          for (int i = 0; i < a.length; i++) {
               a[i] = (int) (Math.random() * 10);
               System.out.println(i + 1 + " " + a[i]);
          }
     }
}
