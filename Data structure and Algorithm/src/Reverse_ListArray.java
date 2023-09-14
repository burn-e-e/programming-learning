import java.util.ArrayList;
import java.util.List;

public class Reverse_ListArray {
    public static void main(String[] args) {
        List<Integer> array = new ArrayList<Integer>(10);
        array.add(4);
        array.add(2);
        array.add(3);
        array.add(7);
        array.add(1);
        for (int element:array){
            System.out.print(element);
            System.out.print("---");
        }
        System.out.println();
        reverseArray(array);
    }
    public static List<Integer> reverseArray(List<Integer> array) {
        // Write your code here
        int size = array.size();
        List<Integer> output = new ArrayList<>();
        System.out.println("Size: "+size);
        for (int i = size; i > 0; i--){
            output.add(array.get(i-1));
            System.out.println("get("+i+"): "+array.get(i-1));
        }
        return output;
    }
}
