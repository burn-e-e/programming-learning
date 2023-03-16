import java.util.Scanner;

public class bd_4 {

  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    int number;
    do {
      number = sc.nextInt();
      if (number < 0) {
        break;
      }
      if (number > 20) {
        continue;
      }
      System.out.println("You entered: " + number);
    } while (true);
    sc.close();
  }
}