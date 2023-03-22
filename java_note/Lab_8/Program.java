package Lab_8;

public class Program {
     public static void main(String[] args) {
          Quadrate q = new Quadrate(5);
          //q.setA(5);
          //q.square();
          q.show("Quadrate ");

          Rectangle r = new Rectangle(4,3);
          //r.setA(5);
          //r.setB(4);
          r.square();
          r.show("Rectangle ");
          r.calcPerimeter();
          r.show();
     }
}
