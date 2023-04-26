package bd4.Second;
public class Main {
    public static void main(String[] args) {
       Person person1 = new Person("Burnee", 19);
       person1.display();
       Sportsman sportman1 = new Sportsman("Burnee", 19, 54, 179);
       sportman1.display();
       sportman1.changeField(170,20);
       sportman1.display("weight");
       TennisPlayer tennisplayer = new TennisPlayer("Burnee", 19, 60, 179, "dragons", "Rookie");
       tennisplayer.display();
       tennisplayer.changeField("Team_Mazaalai");
       tennisplayer.changeField(70, 187);
       tennisplayer.changeField("Tigers");
       Teacher teacher1 = new Teacher("Burnee", 19, "Ahlah", 3400000);
       Teacher teacher2 = new Teacher("Burnee", 18, "Bagsh");
       teacher1.teacherSalary("Ahlah");
       teacher2.teacherSalary("Bagsh");
       teacher1.changeField(30);
       teacher1.display();
       teacher2.display();
    }
}