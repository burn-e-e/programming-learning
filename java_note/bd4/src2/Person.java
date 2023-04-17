package bd4.src2;
public class Person {
    private String name;
    private int age;
    Person(String name, int age){
        this.name = name;
        this.age = age;
    }
    void display(){
        System.out.println("Name: "+ name+ " Age: "+age);
    }
    void changeField(int age){
        this.age = age;
    }
    int getChangedAge(){
        return age;
    }
}
