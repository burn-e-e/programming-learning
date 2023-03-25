package bd_12;

public class Book {
     private String bookName;
     private String author;
     private int price;
     private String publishedDate;
     Book(String bookName,String author,int price,String publishedDate ){
          this.bookName = bookName;
          this.author = author;
          this.price = price;
          this.publishedDate = publishedDate;
     }
     void display(){
          System.out.println("-------------------------------");
          System.out.println("Book Name: " + bookName);
          System.out.println("Author: " + author);
          System.out.println("Price: " + price);
          System.out.println("Published Date: " + publishedDate);
          System.out.println("-------------------------------");
     }
     void changePrice(int price){
          this.price = price;
     }
     String dateTime(){
          return publishedDate;
     }
     
}
