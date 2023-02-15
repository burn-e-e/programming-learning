package Lab_3;
class Rectancle{
     int length;
     int breadth;
     int square;
     int perimeter;
     Rectancle(int a, int b){
          length = a;
          breadth = b;
     }
     void setLength(int a) {
          length = a;
     }
     int getLength() {
          return length;
     }
     void calcSquare() {
          square = length * breadth;
     }
     int getSquare() {
          return square;
     }
     void calcPerimeter() {
          perimeter = 2 * (length + breadth);
     }
     int getPerimeter() {
          return perimeter;
     }
     void display(){
          System.out.println("S= "+square);
     }
}
public class Bodlogo2 {
     public static void main(String[] args) {
          // Rectancle r1 = new Rectancle(4,5);
          // r1.calcSquare();
          // r1.calcPerimeter();
          // r1.display();
          // int t = r1.getPerimeter();
          // System.out.println("P= "+t);
          // r1.setLength(100);
          // r1.calcSquare();
          // r1.calcPerimeter();
          // r1.display();
          // t = r1.getPerimeter();
          // System.out.println("P= "+t);
     

          Rectancle r2 = new Rectancle(10, 20);
          r2.calcSquare();
          r2.calcPerimeter();
          r2.display();
     }
}
