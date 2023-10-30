package DS_A;
import java.util.LinkedList;
import java.util.Queue;

public class Queue_2 {
    public static void main(String[] args) {
/*      add    = enqueue, offer()
        remove = dequeue, poll()
        FIRST IN, FIRST OUT => FIFO
* */
        Queue<String> queue = new LinkedList<String>();
        queue.offer("Karen");
        queue.offer("Chad");
        queue.offer("Steve");
        queue.offer("Sven");
        System.out.println(queue.peek());
        System.out.println(queue.poll());
        System.out.println(queue);
    }
}
