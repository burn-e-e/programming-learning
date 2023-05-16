import java.io.SequenceInputStream;
import java.io.Serializable;
public class Teacher extends Person implements Serializable{
    double salary;
    Teacher(String name, int age, String gender, double salary) {
        super(name, age, gender);
        this.salary = salary;
    }
}
