package bd2.Composition;

public class DemoAggregation {
     public static void main(String[] args) {
          University university = new University("University of California, Berkeley");
          Department department1 = new Department("Computer Science");
          Department department2 = new Department("Engineering");
          Department department3 = new Department("Mathematics");
          university.addDepartment(department1);
          university.addDepartment(department2);
          university.addDepartment(department3);
          university.show();
        }
}
