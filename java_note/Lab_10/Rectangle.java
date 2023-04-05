package Lab_10;

class Rectangle extends Quadrate {
     private int b;
     int perimeter;

     Rectangle(String color, int x, int y) {
          super(color, x);
          b = y;
     }

     void calculatePer() {
          perimeter = (b + getA()) * 2;
     }

     void show() {
          System.out.println("Perimeter"+perimeter);
          super.show();    
      }

     void square() {
          s = getA() * b;
     }
}
