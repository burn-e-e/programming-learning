package DS_A;
import java.util.List;
import java.util.ArrayList;

public class List_0 {
    public static void main(String[] args) {
/*      add    = append to the end, add(index, element)
        remove = remove by index, remove by object
        Access = get(index)
* */
        List<String> list = new ArrayList<String>();
        list.add("Karen");
        list.add("Chad");
        list.add("Steve");
        list.add("Sven");
        System.out.println(list.get(0));
        System.out.println(list.remove(0));
        System.out.println(list);
    }
}
