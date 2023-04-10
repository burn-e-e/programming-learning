package Lab_10_2;

public class Customer {
     private String name;
     public int cost; // Хэрэглэгчийн зардал

     Customer(String name, int cost) {
          this.name = name;
          this.cost = cost;

     }

     public String toString() {
          return name + " " + cost;
     }
}
