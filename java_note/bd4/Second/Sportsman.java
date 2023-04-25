package bd4.Second;

public class Sportsman extends Person {
    private double weight;
    private int height;
    String nameS;

    Sportsman(String name, int age, double weight, int height) {
        super(name, age);
        this.weight = weight;
        this.height = height;
    }

    void display() {
        super.display();
        System.out.println("Sport name" + nameS + "Height: " + height + " Weight: " + weight);
    }
}
