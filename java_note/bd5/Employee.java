package bd5;

public class Employee implements C{
     private String name;
    private double salary;
    private CheckingAccount account1;
    private CreditAccount account2;
    
    public Employee(String name, double salary) {
        this.name = name;
        this.salary = salary;
        this.account1 = new CheckingAccount(1, 0, 0.02); // CheckingAccount with id 1 and PRT rate of 2%
        this.account2 = new CreditAccount(2, 0, 0.05); // CreditAccount with id 2 and PRT rate of 5%
    }
    
    public void incomeImprover(double increase) {
        salary += increase;
    }
    
    public void save() {
        double savedAmount = salary * 0.8;
        account1.addMoney(savedAmount);
    }
    
    public void buy(double amount) {
        if (account1.getRemaining() >= amount) {
            account1.subtractMoney(amount);(amount);
        } else {
            double remainingAmount = amount - account1.getRemaining();
            account1.subtractMoney(account1.getRemaining());
            account2.subtractMoney(remainingAmount);
        }
    }
    
    public void debtPayment(double amount) {
        account2.addMoney(amount);
    }
    
    public void calculatePRT() {
        account1.calculateInterest();
        account2.calculateInterest();
    }
    
    public void display() {
        System.out.println("Name: " + name);
        System.out.println("Salary: " + salary);
        System.out.println("Account 1 Remaining: " + account1.getRemaining());
        System.out.println("Account 2 Remaining: " + account2.getRemaining());
    }
}
