package bd4.src2;

public class Sportsman extends Person {
    private double weight;
    private int height;
    String nameS;

    Sportsman(String name, int age, double weight, int height) {
        super(name, age);
        this.weight = weight;
        this.height = height;
    }

    @Override
    void display() {
        System.out.println("Sport name" + nameS + "Height: " + height + " Weight: " + weight);
    }
    void changeField(double weight){
        this.weight = weight;
    }
    // void display() {
    //     System.out.println("Weight: "+weight);
    //     System.out.println("Age: "+ );
    // }
}
