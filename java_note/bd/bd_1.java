package bd;

import java.util.Scanner;

public class bd_1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        switch (input) {
            case "A" -> System.out.println("91-100");
            case "B" -> System.out.println("81-91")
            case "D" -> System.out.println("61-71");
            case "F" -> System.out.println("51-61");
            default -> System.out.println("Enter A,B,C,D,F");
        }
        sc.close();
    }
}
