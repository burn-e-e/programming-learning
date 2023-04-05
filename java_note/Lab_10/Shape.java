package Lab_10;

abstract class Shape {
     private String color;
     int s;

     Shape(String color) {
          this.color = color;
     }

     // талбай олох функц
     abstract void square();

     // талбай хэвлэх функц
      void show(String t) {
          System.out.println(t+s);
     }

     // Өнгийг буцаах функц
     String getColor() {
          return color;
     }
}
