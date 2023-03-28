package OOP;

public class UsageOfEqual {
     public static void main(String[] args) {
//Example 1 -----------------------------------------------
          String st1 = new String("Hello");
          String st2 = new String("Hello");
          if (st1 == st2) {
               System.out.println("st1 == st2");
          } else {
               System.out.println("st1 != st2");
          }
//Example 2------------------------------------------------
          String str1 = new String("Java");
          String str2 = str1;
          if (str1 == str2) {
               System.out.println("str1 == str2");
          } else {
               System.out.println("str1 != str2");
          }
     }
}
