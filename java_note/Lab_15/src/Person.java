import java.io.Serializable;

import java.io.Serializable;
public class Person implements Serializable {
    String name;
    int age;
    String gender;
    Person(String name, int age, String gender )
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
    void show(){
        System.out.println(name+" "+age);
    }
}
