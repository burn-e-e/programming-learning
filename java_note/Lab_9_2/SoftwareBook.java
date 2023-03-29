package Lab_9_2;
public class SoftwareBook extends Book{
     private int price;
     private String bookVersion;
     
     void set(String name, int price1, int price2, String softwareVersion){
          this.name = name;
          super.price = price1;
          price = price2;
          this.bookVersion = softwareVersion;
     }
     protected void show(){
          super.show();
          System.out.println(price+" "+bookVersion);
     }
}
