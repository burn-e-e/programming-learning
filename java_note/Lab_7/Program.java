package Lab_7;
class Pet{
     private String name;
     public String getName(){
          return name;
     }
     public void setName(String name){
          this.name = name;
     }
     public String speak(){
          return "I don't know what I say!";
     }
}
class Dog extends Pet{
     public String speak(){
          return getName() + " says 'Woof!";
     }
}
public class Program {
     public static void main(String[] args) {
          Pet pet = new Pet();
          Dog bear = new Dog();
          System.out.println(pet.speak());
          System.out.println(bear.speak());
     }
}
