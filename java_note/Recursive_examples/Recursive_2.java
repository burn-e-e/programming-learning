package Recursive_examples;

public class Recursive_2 {

     public static void main(String[] args) {
          long sumOfAllNumbers = sumOfAllNumbers(5);
          System.out.println(sumOfAllNumbers);
     }

     /* A recursive Java example to sum all natural numbers up to a given long. */
     public static long sumOfAllNumbers(long number) {
          /* Stop the recursive Java program at zero */
          if (number != 0) {
               System.out.println(number);
               return number + sumOfAllNumbers(number - 1);
          } else {
               return number; // Program stops here
          }
     }
}