package OOP;
import java.text.*;
public class DecimalFormatEx {
    public static void main(String[] args) {
     DecimalFormat df = new DecimalFormat("0.00");
     double number = 123.4561234321;
     System.out.println(df.format(number));
    }
}
