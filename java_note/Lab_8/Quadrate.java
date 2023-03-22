package Lab_8;
public class Quadrate {
     private int a;
     int s;
     Quadrate(int a) {
          this.a = a;
     }
     void setA(int a) {
          this.a = a;
     }
     int getA() {
          return a;
     }
     void square() {
          s = a * a;
     }
     void show(String p){
          System.out.println(p + " " + s);
     }
}
