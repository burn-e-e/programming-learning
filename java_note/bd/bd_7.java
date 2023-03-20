public class bd_7 {
     public static void main(String[] args) {
          callMyself(9);
     }
     public static void callMyself(long i) {
          if (i <= 0) {
               return;
          } else {
               System.out.print(i + " ");
               i = i - 1;
               callMyself(i);
          }

     }
}