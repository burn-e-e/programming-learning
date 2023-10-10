package DS_A;

import javax.rmi.ssl.SslRMIClientSocketFactory;
import java.util.Stack;

public class Stack_1 {
    public static void main(String[] args) {
        Stack<String> stack = new Stack<String>();
        // Last-In First-Out --LIFO
        stack.push("Dota 2");
        stack.push("Doom");
        stack.push("CS2");
        stack.push("Red Dead Redemption 2");
        System.out.println(stack.pop());
        System.out.println(stack.peek());
        System.out.println(stack);
        System.out.println(stack.search("CS2"));
    }
}
