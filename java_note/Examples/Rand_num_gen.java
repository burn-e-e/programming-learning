package Examples;
import java.util.*;
public class Rand_num_gen {
     public static void main(String[] args) {
          Random rd = new Random();
          int[] massive = new int[10];
          for (int i = 0; i < massive.length; i++) {
               massive[i] = rd.nextInt(10);
               System.out.println(i + 1 + " index of " + massive[i]);
          }
     }
}