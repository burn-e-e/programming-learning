package bd4.Second;
public class Teacher extends Person{
    private String teacher_rank;
    private int teacher_salary;
    Teacher(String name, int age, String teacher_rank, int teacher_salary){
        super(name, age);
        this.teacher_rank = teacher_rank;
        this.teacher_salary=teacher_salary;
    }
    void display(){
        super.display();
        System.out.println("Teacher rank: "+teacher_rank+" Teacher salary "+teacher_salary);
    }
}
