import java.util.*;

public class DSA_List {
    public static void main(String[] args) {
        List<String> groceries = new ArrayList<String>();
        groceries.add("apple");
        groceries.add("banana");
        groceries.add("grape");
        groceries.add("avacados");
        sizeOf(groceries);
        printAll(groceries);
        groceries.remove(0);
        sizeOf(groceries);
        printAll(groceries);
    }
    public static void printAll(List<String> a){
        for (String item:a){
            System.out.print(item+", ");
        }
        System.out.println();
    }
    public static void sizeOf(List<String> a){
        System.out.println("Size of groceries is: "+a.size());
    }
}

