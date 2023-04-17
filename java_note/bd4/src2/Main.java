package bd4.src2;
public class Main {
    public static void main(String[] args) {
        Person[] persons = new Person[4];
        persons[0] = new Sportsman("Burnee", 19, 54, 170);
        persons[1] = new TennisPlayer("Burnee", 19, 54, 170, "Team_Mazaalai", "Silver");
        persons[2] = new Teacher("Burnee", 19, "Doctor", 3400000);
        persons[3] = new Person("Burnee", 19);
        for (Person person : persons) {
            person.display();
        }
    }
}