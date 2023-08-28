package leetcode;

public class valid_parentheses {
    public boolean isValid(String s) {
        String[] open = new String[]{"(", "[", "{"};
        String[] close = {")", "]", "}"};
        for(int i=0;i<=s.length();i++){
            if(close[i].equals(s.charAt(i))){
                if(open[i].equals(s.charAt(i))){
                    return true;
                }
            }
        }
        System.out.println(close[0]);
        return false;
    }
}
