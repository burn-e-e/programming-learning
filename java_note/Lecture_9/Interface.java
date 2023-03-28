package Lecture_9;

public interface Interface {
     public abstract double area();
     public abstract double volume();
}
class c{
     public static void main(String[] args) {
          Interface i = new Interface() {
               public double area() {
                    return 0;
               }
               public double volume() {
                    return 0;
               }
          };
     }
}

