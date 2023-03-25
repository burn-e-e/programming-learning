package bd_12;

import java.time.LocalDate;

public class BookDemo {
     public static void main(String[] args) {
          Book book1 = new Book("Java Programming", "James Gosling", 1000, "2010-01-01");
          Book book2 = new Book("C Programming", "Dennis Ritchie", 2000, "2018-01-01");
          book1.display();
          book2.display();
          LocalDate date = LocalDate.parse(book1.dateTime());
          LocalDate date1 = LocalDate.parse(book2.dateTime());
          if (date.getYear() > 2014) {
               book1.changePrice(10000);
               book2.changePrice(10000);
          }
          if (date1.getYear() > 2014) {
               book1.changePrice(10000);
               book2.changePrice(10000);
          }
          book1.display();
          book2.display();
     }
}
