package DS_A;
import java.util.LinkedList;
public class LinkedList_3 {
    public static void main(String[] args) {
        LinkedList<String> linkedlist = new LinkedList<String>();
//        linkedlist.push("A");
//        linkedlist.push("B");
//        linkedlist.push("C");
//        linkedlist.push("D");
//        linkedlist.push("E");
//        linkedlist.push("F");
//        linkedlist.pop();
        linkedlist.offer("A");
        linkedlist.offer("B");
        linkedlist.offer("C");
        linkedlist.offer("D");
        linkedlist.offer("E");
        linkedlist.offer("F");
        linkedlist.poll();
        System.out.println(linkedlist);
        linkedlist.add(2,"A");
        System.out.println(linkedlist);
    }
}
