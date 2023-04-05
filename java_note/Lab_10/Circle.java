package Lab_10;

class Circle extends Shape {
     final double p = 3.14;
     int r;

     Circle(String color, int r) {
          super(color);
          this.r = r;
     }

     void square() {
          s = (int) (r * r * p);
     }

     void show() {
         System.out.print(getColor());
     }

}