import java.util.Scanner;
public class Stone {
     static public void main(String[] args){
          double h,g=9.81,answer;
          Scanner scan = new Scanner(System.in);
          h = scan.nextDouble();
          scan.close();
          answer = Math.sqrt((h*2)/g);
          System.out.printf("%,.1f", answer);
     }
}
