package Lab_8;

class Rectangle extends Quadrate{
     private int b;
     private int perimeter;
     Rectangle(int m, int n){
          super(m);
          b = n;
     }
     void setB(int b) {
          this.b = b;
     }
     void square(){
          s = getA() * b;
     }
     void calcPerimeter(){
          perimeter = 2 * (getA() + b);
     }
     void show(){
          System.out.println("Perimeter " + perimeter);
     }
}