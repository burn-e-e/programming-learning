import java.lang.management.MemoryNotificationInfo;
import java.util.ArrayList;
import java.util.InputMismatchException;
import java.util.List;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int selected;
        do {
            selected = MenuData();
            switch (selected){
                case 1:
                    System.out.println("---ListArray Selected---");
                    new MyList();
                    break;
                case 2:
                    System.out.println("2");
                    break;
                case 3:
                    System.out.println("3");
                    break;
                case 4:
                    System.out.println("4");
                    break;
            }
        }
        while (selected > 4 || selected < 0);
    }
    public static int MenuData(){
        int selection = 0;
        Scanner sc = new Scanner(System.in);
        System.out.println("---Select your option:---");
        System.out.println("1 - List Array");
        System.out.println("2 - ");
        System.out.println("3 - ");
        System.out.println("4 - ");
        try{
            selection=sc.nextInt();
        }catch (InputMismatchException ex){
           main(null);
        }
        return selection;
    }
}