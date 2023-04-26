package bd4.First;

public class Sportsman extends Person {
    private double weight;
    private int height;

    Sportsman(String name, int age, double weight, int height) {
        super(name, age);
        this.weight = weight;
        this.height = height;
    }

    void display() {
        super.display();
        System.out.println("Height: " + height + " Weight: " + weight);
    }
}
