package bd2.Aggregation;

public class DemoAggregation {
     public static void main(String[] args) {
          Team team = new Team("Team A");
          Student student1 = new Student("John Doe", "123456789");
          Student student2 = new Student("Jane Doe", "987654321");
          team.addStudent(student1);
          team.addStudent(student2);
          team.show();
        }
}
