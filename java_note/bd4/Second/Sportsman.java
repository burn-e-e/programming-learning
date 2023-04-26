package bd4.Second;

public class Sportsman extends Person {
    private double weight;
    private double height;
    String nameS;

    Sportsman(String name, int age, double weight, double height) {
        super(name, age);
        this.weight = weight;
        this.height = height;
    }

    void display() {
        super.display();
        System.out.println("Sport name" + nameS + "Height: " + height + " Weight: " + weight);
    }
    void changeField(double weight, int age){
        this.weight = weight;
        super.changeField(age);
    }
    public void display(String var) {
        switch(var) {
            case "weight":
                System.out.println("Weight: " + weight);
                break;
            case "age":
                System.out.println("Age: " + super.getAge());
                break;
            default:
                System.out.println("Wrong!");
        }
    }
}
