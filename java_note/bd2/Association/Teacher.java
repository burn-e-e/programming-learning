package bd2.Association;

import java.util.List;

public class Teacher {
     private String teacherName;
     private String teacherMajor;
     List<Student> students;
     Teacher(String teacherName, String teacherMajor){
          this.teacherName = teacherName;
          this.teacherMajor = teacherMajor;
     }
     
}
