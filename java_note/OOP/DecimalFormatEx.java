package OOP;
import java.text.*;
import java.util.*;
public class DecimalFormatEx {
    public static void main(String[] args) {
     DecimalFormat df = new DecimalFormat("0.00");
     Formatter f = new Formatter(System.out);
     double number = 123.4561234321;
     System.out.println(df.format(number));
     int a = 456;
     f.format("%7d", a);
     System.out.format("%10d", a);
     f.close();
    }
}
