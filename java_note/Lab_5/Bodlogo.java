import java.util.Scanner;

public class Bodlogo {
     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          int n;
          System.out.println("Enter n number");
          n = sc.nextInt();
          Employee[] e = new Employee[n];
          String name;
          int age;
          int workedDay;
          int salaryPerDay;
          for (int i = 0; i < e.length; i++) {
               System.out.println("Enter ur Name:");
               name = sc.next();
               System.out.println("Enter ur Age:");
               age = sc.nextInt();
               System.out.println("Enter ur worked day:");
               workedDay = sc.nextInt();
               System.out.println("Enter ur Salaryperday:");
               salaryPerDay = sc.nextInt();
               e[i] = new Employee(name, age, workedDay, salaryPerDay);
          }
          for(int i = 0; i<e.length;i++){
               e[i].calcTotalSalary();
               e[i].display();
               System.out.println(e[i].getTotalSalary());
          }
          sc.close();
     }
}
