package DS_A;
import java.util.Stack;

public class Stack_1 {
    public static void main(String[] args) {
        Stack<String> stack = new Stack<String>();

        //        add    = push()
        //        remove = pop()
        //        FIRST IN LAST OUT

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
