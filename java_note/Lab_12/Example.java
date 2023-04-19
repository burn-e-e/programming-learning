package Lab_12;

import java.util.Scanner;
import java.util.Random;

class Person {
     String name;
     int age;
     // Person(String name, int age){
     //      this.name = name;
     //      this.age = age;
     // }
     void setName(String name) {
          this.name = name;
     }

     String getName() {
          return name;
     }

     void setAge(int age) {
          this.age = age;
     }

     int getAge() {
          return age;
     }

     void show() {
          System.out.println("Name: " + name + " Age: " + age);
     }
}

public class Example {
     public static void main(String[] args) {
          int[] number = new int[5];
          Scanner sc = new Scanner(System.in);
          Random rand = new Random();
          for (int i = 0; i < number.length; i++) {
               number[i] = rand.nextInt(10);
               System.out.println((i + 1) + ". " + number[i]);
          }
          int sum = 0;
          for (int n : number) {
               sum = sum + n;
          }
          System.out.println("Sum is " + sum);
          // Example 2

          
          Person[] people = new Person[2];
          // people[0].setName("Burnee");
          // people[1].setName("Bat");
          for (int i = 0; i < people.length; i++) {
               people[i] = new Person();
               System.out.println("Enter " + (i + 1) + " name");
               people[i].setName(sc.next());
          }
          for (Person person : people) {
               System.out.println(person.getName());
          }
     }
}
