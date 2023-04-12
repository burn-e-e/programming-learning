package Lecture_11;

import java.util.InputMismatchException;
import java.util.Scanner;

class Person {
     private String name;
     private int age;
     private char gender;

     void setName(String name) {
          this.name = name;
     }

     void setAge(int age) {
          this.age = age;
     }

     void setGender(char gender) {
          this.gender = gender;
     }

     String getName() {
          return name;
     }

     int getAge() {
          return age;
     }

     char getChar() {
          return gender;
     }
}

public class Class_Array {
     public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);
          Person[] person;
          int size;
          System.out.print("Enter how many person to create: ");
          try {
               size = sc.nextInt();
          } catch (InputMismatchException e) {
               System.out.println("Enter Integer");
               return;
          }
          person = new Person[size];
          String name, insStr;
          int age;
          char gender;

          for (int i = 0; i < person.length; i++) {
               person[i] = new Person();
               System.out.print("Enter name ");
               name = sc.next();
               System.out.print("Enter age ");
               try {
                    age = sc.nextInt();
                    sc.nextLine();
               } catch (InputMismatchException e) {
                    System.out.println("Wrong input please enter number");
                    return;
               }
               System.out.print("Enter gender(f or m) ");
               insStr = sc.next();
               gender = insStr.charAt(0);
               person[i].setName(name);
               person[i].setAge(age);
               person[i].setGender(gender);

          }
          for (Person p : person) {
               System.out.println("Name: " + p.getName() + " Age: " + p.getAge() + " Gender: " + p.getChar());
          }
          System.out.println("If you want to find oldest man and youngest man - (1)");
          int option = sc.nextInt();
          switch (option) {
               case 1:
                    int minIdx = 0;
                    int maxIdx = 0;
                    for (int i = 0; i < person.length; i++) {
                         if (person[i].getAge() < person[minIdx].getAge()) {
                              minIdx = i;
                         } else if (person[i].getAge() > person[maxIdx].getAge()) {
                              maxIdx = i;
                         }
                    }
                    System.out.println("Oldest person is " + person[maxIdx].getName() + " " + person[maxIdx].getAge());
                    System.out.println(
                              "Youngest person is " + person[minIdx].getName() + " " + person[minIdx].getAge());
                    break;
               default:
                    break;
          }
          sc.close();
     }
}
