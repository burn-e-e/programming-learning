package bd4.Second;

import javax.swing.event.SwingPropertyChangeSupport;

public class Teacher extends Person{
    private String teacher_rank;
    private int teacher_salary;

    Teacher(String name, int age, String teacher_rank, int teacher_salary){
        super(name, age);
        this.teacher_rank = teacher_rank;
        this.teacher_salary=teacher_salary;
    }
    Teacher(String name, int age,String teacher_rank){
        super(name, age);
        this.teacher_rank = teacher_rank;
    }
    void display(){
        super.display();
        System.out.println("Teacher rank: "+teacher_rank+" Teacher salary "+teacher_salary);
    }
    void teacherSalary(String rank){
        teacher_rank = rank;
        switch(rank){
            case "Ahlah":
                teacher_salary = 4000000;
                break;
            case "Bagsh":
                teacher_salary = 3000000;
                break;
            case "Tuslah":
                teacher_salary = 2000000;
                break;
            default:
                System.out.println("Ahlah esvel Bagsh esvel Tuslah gj oruulna uu");
        }
    }
}
