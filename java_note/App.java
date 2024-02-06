import java.util.Scanner;
public class App {
 private static final double PI = 3.14;
 private final double radius;
 public App(double radius) {
 this.radius = radius;
 }
 public static void main(String[] args) {
 System.out.println("------------------------------------------------------------");
 System.out.println("CircleCalc v1.0");
 System.out.println();
 System.out.println("Calculates and prints information for a user-supplied radius");
 System.out.println("------------------------------------------------------------");
 System.out.print("Enter the circle's radius: ");
 Scanner in = new Scanner(System.in);
 App c = new App(in.nextFloat());
 // TODO: compute and print the circumference and area of the circle
 }
}
// 3:08