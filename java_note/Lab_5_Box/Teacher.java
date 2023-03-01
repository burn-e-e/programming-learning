package Lab_5_Box;

public class Teacher {
     private String name;
     public void setName(String n){
          name = n;
     }
     public void display(Student t){
          System.out.print(t.getName());
          System.out.print(name);
     }
}
