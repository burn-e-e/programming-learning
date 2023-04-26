package bd4.Second;
public class TennisPlayer extends Sportsman{
    private String nameS;
    private String player_rank;
    TennisPlayer(String name, int age, int weight,int height,String p_team, String p_rank){
        super(name, age, weight, height);
        nameS = p_team;
        player_rank = p_rank;
    }
    void display(){
        super.display();
        System.out.println("Player team: "+nameS+" Player rank: "+player_rank);
    }
    void changeField(String team) {
        this.nameS = team;
    }
    public void display(String var) {
        switch(var) {
            case "nameS":
                System.out.println("Sport Name: " + super.nameS);
                break;
            case "age":
                System.out.println("Age: " + super.getAge());
                break;
            default:
                System.out.println("Wrong!");
        }
    }
}
