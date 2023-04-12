package Lab_11;
class Ex extends Exception{
     Ex(String msg){
          super(msg);
     }
}
public class Test {

     public static void main(String[] args) {
          String code = "J.IT13D001";
          try {
               Check(code);
               System.out.println("Ene code zuv baina");
          } catch (NumberFormatException e) {
               System.out.println(e.getMessage());
          } catch (Ex e) {
               System.out.println(e.getMessage());
          }

     }

     static void Check(String c) throws Ex, NumberFormatException {
          int len = c.length();
          if (Character.isLetter(c.charAt(0)) && Character.isLetter(c.charAt(6))) {

          } else {
               throw new Ex("0 bolon 6 temdegt useg baih ystoi");
          }
          if (c.charAt(1) != '.') {
               throw new Ex("1 index is not .");
          }
          if (c.substring(2, 4).equals("IT") != true) {
               throw new Ex("IT bish baina");
          }
          if (Character.isDigit(c.charAt(4)) && Character.isDigit(c.charAt(5)) && Character.isDigit(c.charAt(7))
                    && Character.isDigit(c.charAt(8)) && Character.isDigit(c.charAt(9))) {
          } else {
               throw new NumberFormatException("Too baih ystoi");
          }
     }
}
