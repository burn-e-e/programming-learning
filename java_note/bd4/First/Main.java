package bd4.First;
public class Main {
    public static void main(String[] args) {
        Person[] people = new Person[4];
        people[0] = new Sportsman("Burnee", 19, 54, 170);
        people[1] = new TennisPlayer("Burnee", 19, 54, 170, "Team_Mazaalai", "Silver");
        people[2] = new Teacher("Burnee", 19, "Doctor", 3400000);
        people[3] = new Person("Burnee", 19);
        for (Person person : people) {
            person.display();
        }
    }
}