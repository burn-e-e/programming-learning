// Create a Main class
public class OOP_2 {
  int x;  // Create a class attribute

  // Create a class constructor for the Main class
  public void Myclass() {
    x = 5;  // Set the initial value for the class attribute x
  }

  public static void main(String[] args) {
    Myclass myObj = new Myclass(); // Create an object of class Main (This will call the constructor)
    System.out.println(myObj.x); // Print the value of x
  }
}
