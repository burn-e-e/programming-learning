package Lecture_11;
import java.util.Scanner;

public class Program {
     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          int size;
          int number[];
          System.out.println("Enter size of array: ");
          size = sc.nextInt();
          number = new int[size];
          for(int i = 0; i<size;i++){
               System.out.println("Enter "+(i+1)+" index of array");
               number[i] = sc.nextInt();
          }
          for(int i = 0; i<size;i++){
               System.out.println(i+1 + ". " + number[i]);
          }
          sc.close();
     }
}
