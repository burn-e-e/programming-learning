package bd_3;
import java.util.Scanner;
public class Main {
     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          User user1 = new User("Bat", 654000, "0000");
          System.out.println("Enter password: ");
          String password = sc.nextLine();
          if (password.length() == 4) {
               if (user1.getPassword().equals(password)) {
                    System.out.println("Password is correct");
                    System.out.println("Check your balance: 1");
                    System.out.println("Withdraw: 2");
                    System.out.println("Transfer: 3");
                    int choice = sc.nextInt();
                    switch (choice) {
                         case 1:
                              System.out.println("Your balance is: " + user1.getBalance());
                              break;
                         case 2:
                              double withdraw;
                              System.out.print("Enter amount to withdraw: ");
                              withdraw = sc.nextDouble();
                              System.out.println("Your balance: " + user1.withdraw(withdraw));
                              break;
                         case 3:
                              double transfer;
                              System.out.print("Enter account to transfer: ");
                              String transferTo = sc.next();
                              if (transferTo.length() == 15) {
                                   System.out.println("Account is correct");
                                   System.out.print("Enter amount to transfer: ");
                                   transfer = sc.nextDouble();
                                   System.out.println(user1.transfer(transfer));
                              } else {
                                   System.out.println("Account is incorrect");
                              }
                              break;
                         default:
                              System.out.println("Invalid choice");
                              break;
                    }
               } else {
                    System.out.println("Password is incorrect");
               }
          } else {
               System.out.println("Password should have 4 digit: hint");
          }
          sc.close();
     }
}
