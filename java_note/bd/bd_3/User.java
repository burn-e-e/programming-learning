package bd_3;

public class User {
     String name;
     double balance;
     String password;

     User(String name, double balance, String password) {
          this.name = name;
          this.balance = balance;
          this.password = password;
     }
     String getPassword(){
          return this.password;
     }
     double getBalance() {
          return balance;
     }

     double withdraw(double amount) {
          if(amount > balance) {
               System.out.println("Your balance is not enough!");
               return balance;
          } else {
               return balance -= amount;
          }
     }

     double transfer(double amount) {
          if(amount > balance) {
               System.out.println("Your balance is not enough!");
               return balance;
          } else {
               return balance -= amount;
          }
     }
}
