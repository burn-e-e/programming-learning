package bd4.First;
public class TennisPlayer extends Sportsman{
    private String player_team;
    private String player_rank;
    TennisPlayer(String name, int age, int weight,int height,String p_team, String p_rank){
        super(name, age, weight, height);
        player_team = p_team;
        player_rank = p_rank;
    }
    void display(){
        super.display();
        System.out.println("Player team: "+player_team+" Player rank: "+player_rank);
    }
}
