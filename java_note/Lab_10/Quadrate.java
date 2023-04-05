package Lab_10;

class Quadrate extends Shape {
     private int a;
     Quadrate(String color, int c) {
          super(color);
          a = c;
     }

     void show() {
          System.out.print(getColor());
      }
     int getA() {
          return a;
     }
     void square() {
          s = a * a;
     }
}
