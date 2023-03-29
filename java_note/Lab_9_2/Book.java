package Lab_9_2;
public class Book{
     protected String name;
     private int pages;
     protected double price;
     
     public void set(int pages){
          this.pages = pages;
     }
     protected void show(){
          System.out.println("Book name: " + name);
          System.out.println("Book pages : " + pages);
          System.out.println("Book price: " +  price);
     }
}