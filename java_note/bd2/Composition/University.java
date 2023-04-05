package bd2.Composition;
import java.util.ArrayList;

public class University {
     private String name;
     private ArrayList<Department> departments;
   
     public University(String name) {
       this.name = name;
       this.departments = new ArrayList<>();
     }
   
     public void addDepartment(Department department) {
       departments.add(department);
     }
   
     public void show() {
       System.out.println("University name: " + name);
       for (Department department : departments) {
         department.print();
       }
     }
   }