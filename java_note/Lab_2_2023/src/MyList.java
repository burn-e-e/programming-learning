import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class MyList extends Main{
    Scanner sc = new Scanner(System.in);
    int size = 10;
    List<Integer> array = new ArrayList<>(size);
    MyList(){
        String selected;
        boolean option = true;
        int counter=0;
        do {
            selected = MenuList();
            if (selected.equals("e")){
                option = false;
            }else if (isNumber(selected)){
                int n = Integer.parseInt(selected);
                counter++;
                array.add(n);
                for (int num : array) {
                    System.out.print(" ["+num+"]");
                }

            }else {
                for (int num : array) {
                    System.out.print(" ["+num+"]");
                }
                System.out.println("\n---Wrong input!---");
            }
        }while (option);
        if (counter==0){
            main(null); //Call back main class
        }else if (counter > 0){
            modifyMenu(array);
        }
    }
    public static void modifyMenu(List<Integer> arr){
        Scanner sc  = new Scanner(System.in);
        for (int num : arr) {
            System.out.print(" ["+num+"]");
        }
        System.out.println("\n1 - Add");
        System.out.println("2 - Remove");
        System.out.println("3 - Switch");
        System.out.println("4 - Min");
        System.out.println("5 - Max");
        System.out.println("e - Exit");
        int choose = sc.nextInt();
    }
    public static String MenuList(){
        String choice;
        Scanner sc = new Scanner(System.in);
        System.out.println("\ne - Exit");
        System.out.print("Enter input: ");
        choice = sc.nextLine();
        return choice;
    }
    public static boolean isNumber(String str){
        if (str == null){
            return false;
        }
        try{
            int n = Integer.parseInt(str);
        }catch (NumberFormatException nfe){
            return false;
        }
        return true;
    }
    static int max(List<Integer> array){
        int size = array.size();
        int max=array.get(0);
        for (int i = 0 ; i<size ; i++){

            if(max < array.get(i)){
                max=array.get(i);
            }
        }
        return max;
    }
    static int min(List<Integer> array){
        int size = array.size();
        int min=array.get(0);
        for (int i = 0 ; i<size ; i++){

            if(min > array.get(i)){
                min=array.get(i);
            }
        }
        return min;
    }
    static int sum(List<Integer> array){
        int sum=0;
        int size = array.size();
        for (int i = 0; i< size ; i++){
            sum+=array.get(i);
        }
        return sum;
    }
    static int average(List<Integer> array){
        int average=0;
        int size = array.size();
        for (Integer integer : array) {
            average += integer;
        }
        average/=size;
        return average;
    }
    static List<Integer> removeOdd(List<Integer> array){
        List<Integer> removeOdd = new ArrayList<>(10);
        int size = array.size();
        for (Integer integer : array) {
            if (integer % 2 == 0) {
                removeOdd.add(integer);
            }
        }
        return removeOdd;
    }
    static List<Integer> sort(List<Integer> array){

        Collections.sort(array);
        return array;
    }
}
