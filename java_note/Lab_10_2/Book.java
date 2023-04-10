package Lab_10_2;

public class Book {
     private String bookName;
     private int bookPrice;
     private int bookCount;
     Book(String bookName,int bookPrice,int bookCount){
          this.bookName = bookName;
          this.bookPrice = bookPrice;
          this.bookCount = bookCount;
     }
     void show(){
          System.out.println(bookName+" "+bookPrice+" "+bookCount);
     }
     int getBookPrice(){
          return bookPrice;
     }
     int changeBookCount(int number){
          return bookCount - number;
     }
}
