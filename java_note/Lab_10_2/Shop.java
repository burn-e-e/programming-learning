package Lab_10_2;

public class Shop {
     private String name;
     private String address;

     Shop(String name, String address) {
          this.name = name;
          this.address = address;
     }

     public String toString() {
          return name + " " + address;
     }
}
