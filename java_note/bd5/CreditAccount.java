package bd5;

public class CreditAccount extends Account{
     private double debt;

     CreditAccount(int id, int remaining, double debt) {
          super(id, remaining);
          this.debt = debt;
     }

     @Override
     public void addMoney(double amount) {
          if (debt > 0) {
               // subtract money from debt first, then add to remaining
               // update remaining and debt
          } else {
               setRemaining(getRemaining() + amount);
          }
     }

     @Override
     public void subtractMoney(double amount) {
          if (getRemaining() >= amount) {
               setRemaining(getRemaining() - amount);
          } else {
               // calculate remaining amount to be taken from bank account
               // subtract remaining amount from bank account
               // update remaining amount of account
               // add remaining amount to debt
          }
     }

     @Override
     public void display() {
          // display account details
     }

     @Override
     public void calculateInterest() {
        
     }
}
