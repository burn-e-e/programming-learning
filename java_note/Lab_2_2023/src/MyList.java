import java.util.*;
import java.util.Iterator;
public class MyList extends Main{
    Scanner sc = new Scanner(System.in);
    List<Integer> array = new ArrayList<>();
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
        do{
            for (int num : arr) {
                System.out.print(" ["+num+"]");
            }
            System.out.println("\n1 - Add");
            System.out.println("2 - Add at index");
            System.out.println("3 - Remove by index");
            System.out.println("4 - Remove by element");
            System.out.println("5 - Switch");
            System.out.println("6 - Min");
            System.out.println("7 - Max");
            System.out.println("8 - Sort");
            System.out.println("9 - Average");
            System.out.println("10 - Sum");
            System.out.println("11 - Remove odd Numbers");
            System.out.println("12 - Search element");
            System.out.println("13 - Exit");
            int choose = 0;
            try{
                choose=sc.nextInt();
            }catch (InputMismatchException ex){
                modifyMenu(arr);
            }
            switch(choose){
                case 1:
                    System.out.println("Enter number that you want to add ");
                    arr.add(sc.nextInt());
                    break;
                case 2:
                    System.out.println("Enter your index and number ");
                    arr.add(sc.nextInt(), sc.nextInt());
                    break;
                case 3:
                    System.out.println("Enter number's index that you want to remove ");
                    try{
                        arr.remove(sc.nextInt());
                    }catch (IndexOutOfBoundsException ex){
                        System.out.println("Enter only existing index!");
                        modifyMenu(arr);
                    }
                    break;
                case 4:
                    System.out.println("Enter element that you want to remove");
                    int relement = sc.nextInt();
                    Iterator<Integer> iterator = arr.iterator();
                    while (iterator.hasNext()) {
                        if (iterator.next() == relement) {
                            iterator.remove();
                        }
                    }
                    break;
                case 5:
                    System.out.println("Enter indexes to change their position");

                    int findex = sc.nextInt();
                    int sindex = sc.nextInt();
                    try{
                        int fnum = arr.get(findex);
                        int snum = arr.get(sindex);
                        arr.remove(findex);
                        arr.add(findex,snum);
                        arr.add(sindex,fnum);
                    }catch(IndexOutOfBoundsException ex){
                        System.out.println("Enter only existing indexes!");
                        modifyMenu(arr);
                    }

                    break;
                case 6:
                    System.out.println("Min number is "+min(arr));
                    break;
                case 7:
                    System.out.println("Max number is "+max(arr));
                    break;
                case 8:
                    System.out.println("Sort number is "+sort(arr));
                    break;
                case 9:
                    System.out.println("Average number is "+average(arr));
                    break;
                case 10:
                    System.out.println("Sum number is "+sum(arr));
                    break;
                case 11:
                    System.out.println("Removed odd numbers");
                    arr = removeOdd(arr);
                    if (arr.isEmpty()){
                        System.out.println("All odd numbers are removed");
                    }
                    break;
                case 12:
                    System.out.print("Enter the element that you want to search: ");
                    int sElement = sc.nextInt();
                    int count = 0;

                    Iterator<Integer> ite = arr.iterator();
                    int currentIndex = 0; // Keep track of the current index

                    while (ite.hasNext()) {
                        int currentElement = ite.next();
                        if (currentElement == sElement) {
                            System.out.println((currentIndex + 1) + ". Your entered number " + sElement + " is at index " + currentIndex);
                            count++;
                        }
                        currentIndex++;
                    }

                    if (count == 0) {
                        System.out.println("Element " + sElement + " was not found in the ArrayList.");
                    }
                    break;
                case 13:
                    main(null);
                    break;
                default:
                    System.out.println("Wrong input");
            }
        }while(true);
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
