package bd5;

public class CheckingAccount extends Account implements C {

     private int PRTamount;

     CheckingAccount(int id, int remaining, double d) {
          super(id, remaining);
          this.PRTamount = d;
     }

     public void PRTCalculatorFunction() {
          if (getRemaining() < 1000000) {
               PRTcalculation();
          } else {
               calculateInterest();
          }
          // add money to remaining after PRT calculation
     }

     private void PRTcalculation() {
          // calculate PRT based on remaining and PRTamount
     }

     public void calculateInterest() {
          // calculate PRT based on remaining and checking account rules
     }

     @Override
     public void addMoney(double amount) {
          setRemaining(getRemaining() + amount);
     }

     @Override
     public void subtractMoney(double amount) {
          if (getRemaining() >= amount) {
               setRemaining(getRemaining() - amount);
          } else {
               // calculate remaining amount to be taken from bank account
               // subtract remaining amount from bank account
               // update remaining amount of account
          }
     }

     @Override
     public void display() {
          // display account details
     }

     public void deposit(double savedAmount) {
     }

}
