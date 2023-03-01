public class Employee {
     // ner, nas , ajillasan odor, neg odriin tsalin, niit tsalin
     String name;
     int age;
     int workedDay;
     int salaryPerDay;
     int totalSalary;

     Employee(String name, int age, int workDay, int salaryPerDay) {
          this.name = name;
          this.age = age;
          this.workedDay = workDay;
          this.salaryPerDay = salaryPerDay;
     }

     public void calcTotalSalary() {
          totalSalary = workedDay * salaryPerDay;
     }

     public void display() {
          System.out.println(name + " " + age);
     }

     public int getTotalSalary() {
          return totalSalary;
     }
}