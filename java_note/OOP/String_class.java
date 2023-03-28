package OOP;

import java.util.*;

public class String_class {
     public static void main(String[] args) {
          String greeting = "Hello";
          String test = new String("Test123");
          System.out.println(greeting);
          System.out.println(test);

          char[] HelloArray = { 'h', 'e', 'l', 'l', 'o', '.' };
          String helloString = new String(HelloArray);
          System.out.println(helloString);

          int len = helloString.length();
          System.out.println(len);

          System.out.println(helloString.concat(test));

          // --------------------------------------------------------------------------//
          Scanner sc = new Scanner(System.in);
          char letter;
          System.out.println("What is your name: ");
          String name = sc.next();
          int numberofcharacters = name.length();
          int vowelcount = 0;
          for (int i = 0; i < numberofcharacters; i++) {
               letter = name.charAt(i);
               if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A'
                         || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U') {
                    vowelcount++;
               }
          }
          System.out.println("Number of vowels in your name is: " + vowelcount);
          sc.close();
     }
}
