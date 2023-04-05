package bd2.Composition;

public class Department {
     private String name;
   
     public Department(String name) {
       this.name = name;
     }
   
     public void print() {
       System.out.println("Department name: " + name);
     }
   }
