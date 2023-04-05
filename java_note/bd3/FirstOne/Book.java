package bd3.FirstOne;

import java.sql.Date;

public class Book {
     String bookname;
     String bookauthor;
     int bookprice;
     Date bookdate;
     int booksumprice;
     int bookavgprice;
     Book(String bookname, String bookauthor, int bookprice,Date bookdate){
           this.bookname = bookname;
           this.bookauthor = bookauthor;
           this.bookprice = bookprice;
           this.bookdate = bookdate;
     }
}
