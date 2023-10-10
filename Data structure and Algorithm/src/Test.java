public class Test {
    public static void main(String[] args) {
        System.out.println(sum(4));
    }
    static public int sum(int a){
        if (a <= 0){
            return 0;
        }
        return a+sum(a-1);
    }
}
