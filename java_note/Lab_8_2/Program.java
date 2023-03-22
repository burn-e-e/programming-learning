package Lab_8_2;

public class Program {
     public static void main(String[] args) {
          Person p1 = new Person("Ivan", 20);
          p1.show();
          Student s1 = new Student("Burentugs", 21, 4, "Software Programming");
          s1.show();
          Teacher t1 = new Teacher("Bat", 44, "Math", 999999);
          t1.show();
          System.out.println(t1.subject + "" + t1.salary);
     }
}
