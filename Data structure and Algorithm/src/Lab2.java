import java.sql.Array;
import java.util.*;

public class Lab2 {
    public static final String yellow = "\u001B[33m";
    public static final String reset = "\u001B[0m";
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter size of List: ");
        int n = sc.nextInt();
        List<Integer> array = new ArrayList<Integer>(n);
        while(n>0){
            System.out.println("Enter element of List: ");
            array.add(sc.nextInt());
            n--;
        }
        System.out.print(yellow+ "ArrayList: "+reset);
        for (int element:array){
            System.out.print(yellow+"[ "+element+" ]"+reset);
        }

        System.out.println("\n1 --> Add");
        System.out.println("2 --> Remove");
        System.out.println("3 --> Min");
        System.out.println("4 --> Max");
        System.out.println("5 --> Sum");
        System.out.println("6 --> Average");
        System.out.println("7 --> Remove Odd");
        System.out.println("8 --> Sort");
        System.out.println("0 --> Reenter list of number");
        int a=1;
        while(a > 0){
            int c = sc.nextInt();
            switch (c){
                case 0:
                    start();
                    break;
                case 1:
                    int index;
                    int number;
                    System.out.println("Enter index: ");
                    index = sc.nextInt();
                    System.out.println("Enter number: ");
                    number = sc.nextInt();
                    array.add(index,number);
                    enter(array);
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    System.out.println("\n1 --> Add");
                    System.out.println("2 --> Remove");
                    System.out.println("3 --> Min");
                    System.out.println("4 --> Max");
                    System.out.println("5 --> Sum");
                    System.out.println("6 --> Average");
                    System.out.println("7 --> Remove Odd");
                    System.out.println("8 --> Sort");
                    System.out.println("0 --> Reenter list of number");
            }
        }
    }
    static void enter(List<Integer> array){
        System.out.print(yellow+ "ArrayList: "+reset);
        for (int element:array){
            System.out.print(yellow+"[ "+element+" ]"+reset);
        }

        System.out.println("\n1 --> Add");
        System.out.println("2 --> Remove");
        System.out.println("3 --> Min");
        System.out.println("4 --> Max");
        System.out.println("5 --> Sum");
        System.out.println("6 --> Average");
        System.out.println("7 --> Remove Odd");
        System.out.println("8 --> Sort");
        System.out.println("0 --> Reenter list of number");
    }
    static void start(){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter size of List: ");
        int n = sc.nextInt();
        List<Integer> array = new ArrayList<Integer>(n);
        while(n>0){
            System.out.println("Enter element of List: ");
            array.add(sc.nextInt());
            n--;
        }
        System.out.print("Your entered list of numbers are ");
        for (int element:array){
            System.out.print("[ "+element+" ]");
        }
        System.out.println("Add --> 1");
        System.out.println("Remove --> 2");
        System.out.println("Min --> 3");
        System.out.println("Max --> 4");
        System.out.println("Sum --> 5");
        System.out.println("Average --> 6");
        System.out.println("Remove Odd --> 7");
        System.out.println("Sort --> 8");
        System.out.println("Reenter list of numbers --> 0");
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
