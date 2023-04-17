public class Sportsman extends Person{
    private int weight;
    private int height;
    Sportsman(String name, int age, int weight, int height){
        super(name,age);
        this.weight =weight;
        this.height = height;
    }
    @Override
    void display(){
        System.out.println("Height: "+height+" Weight: "+weight);
    }
}
