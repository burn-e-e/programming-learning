package Labs;

import java.util.Scanner;

public class Test {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the size of the array:");
        int size = scanner.nextInt();
        Object[] massive = new Object[size];

        for (int i = 0; i < size; i++) {
            System.out.println("Enter value for index " + i + ":");
            massive[i] = scanner.next();
        }

        // Print the array to verify input
        for (int i = 0; i < size; i++) {
            System.out.println("massive[" + i + "] = " + massive[i]);
        }
    }
}
