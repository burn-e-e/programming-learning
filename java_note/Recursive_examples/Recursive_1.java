package Recursive_examples;
public class Recursive_1 {

     public static void main(String[] args) {
          callMyself(9);
          // Prints 9 to 1
     }

     /* The recursive Java method */
     public static void callMyself(long i) {
          if (i <= 0) {
               return; // program stops here
          } else {
               System.out.print(i + " ");
               i = i - 1;
               callMyself(i);
          }

     }
}