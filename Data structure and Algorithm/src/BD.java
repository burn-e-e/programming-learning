import java.util.*;

public class BD{
    public static void main(String[] args) {
        int N = getRandomInRange(5,11); //convoy of Trains
        int M = getRandomInRange(10,21); //Places
        List<List<Character>> ln = new ArrayList<>();
        List<Character> tsuwaa= new ArrayList<>();
        System.out.println("Convoy of Trains: "+N);
        System.out.println("Places: "+M);


        List<String> plM = new ArrayList<>();
        for (char letter = 'A'; letter < 'A' + M; letter++) {
            plM.add(String.valueOf(letter));
        }
        System.out.println(plM);

        for (int i = 0; i < N; i++) {
            tsuwaa= new ArrayList<>();
            ln.add(tsuwaa);
            int numChars = getRandomInRange(3,31);
            for (int j = 0; j < numChars; j++) {
                tsuwaa.add(getPlacesToGo(M));
            }
        }
        for (int i = 0; i < ln.size(); i++) {
            System.out.println("Цуваа ln" + (i+1) + " (size " + ln.get(i).size() + "): " + ln.get(i));
        }
        //--------------------------------------------------------------------



    }
    public static int getRandomInRange(int min, int max){
        return (int) ((Math.random() * (max - min)) + min);
    }
    private static char getPlacesToGo(int M){
        char start = 'a';
        char end = (char) (start + M - 1);
        Random rd = new Random();
        return (char) (start + rd.nextInt(end - start + 1));
    }

}
