public class bd_3 {
     String name;

     String A(String input) {
          name = input;
     }

     String A() {
          this("John");
     }

     void show() {
          System.out.println(name);
     }

     public static void main(String args[]) {
          A p1 = new A("James");
          A p2 = new A();
          p1.show();
          p2.show();
     }
}