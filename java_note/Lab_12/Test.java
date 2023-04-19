package Lab_12;
import java.util.Collections;
import java.util.LinkedList;
public class Test {
    
   public static void main(String[] args) {
      LinkedList<Teacher> t = new LinkedList<Teacher>();
      t.add(new Teacher("Burnee","A1"));
      t.add(new Teacher("Bat","A1"));
      t.add(new Teacher("Bold","A1"));
      
      
     Collections.sort(t);


   }  
}
