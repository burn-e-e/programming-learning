package bd3.FirstOne;

import java.util.Scanner;

public class BookDemo extends Book {
     public BookDemo(Book book) {
          super(book);
     }

     public static void main(String[] args) {
           String bookName;
           String bookAuthor;
           int bookPrice;
           String datePrinted;
          Book[] book;
          int size;
          Scanner sc = new Scanner(System.in);
          size = sc.nextInt();
          book = new Book[size];
          for(int i=0;i<book.length;i++){
               bookName = sc.next();
               bookAuthor =sc.next();
               bookPrice = sc.nextInt();
               datePrinted = sc.next();
               book[i].setBookName(bookName);
               book[i].setBookAuthor(bookAuthor);
               book[i].setBookPrice(bookPrice);
               book[i].setDatePrinted(datePrinted);
          }
          for(int i=0;i<book.length;i++){
               sumOfAllBooks += book[i].bookPrice;
          }
          averagePriceOfBooks = sumOfAllBooks / book.length;
          for(int i=0;i<book.length;i++){
               book[i].display();
          }
          // sumOfAllBooks = book1.bookPrice + book2.bookPrice + book3.bookPrice + book4.bookPrice + book5.bookPrice;
          // averagePriceOfBooks = sumOfAllBooks / 5;
  
          // book1.display();
          // book2.display();
          // book3.display();
          // book4.display();
          // book5.display();
  
          // BookDemo.changePrice(book1);
          // BookDemo.changePrice(book3);
  
          // book1.display();
          // book2.display();
          // book3.display();
          // book4.display();
          // book5.display();
          sc.close();
          System.out.println("The sum of all books is " + sumOfAllBooks);
          System.out.println("The average price of books is " + averagePriceOfBooks);
      }
}
