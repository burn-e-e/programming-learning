package Lab_12;

import java.util.ArrayList;

public class Teacher implements Comparable {
     private String name;
     private String department;
     private ArrayList<Student> s = new ArrayList<Student>();

     Teacher(String name, String department) {
          this.name = name;
          this.department = department;
     }

     public int compareTo(Object o) {
          Teacher t = (Teacher) o;
          if (name.length() > t.name.length()) {
               return 1;
          } else if (name.length() < t.name.length()) {

          }
     }
}
