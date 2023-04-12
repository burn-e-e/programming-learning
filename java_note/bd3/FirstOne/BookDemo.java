package bd3.FirstOne;

public class BookDemo extends Book{
     public BookDemo(Book book) {
          super(book);
     }
     public static void main(String[] args) {
          Book book1 = new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954, "September 21");
          Book book2 = new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979, "October 12");
          Book book3 = new Book("The Da Vinci Code", "Dan Brown", 2003, "May 18");
          Book book4 = new Book("The Hunger Games", "Suzanne Collins", 2008, "September 14");
          Book book5 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997, "June 26");
  
          sumOfAllBooks = book1.bookPrice + book2.bookPrice + book3.bookPrice + book4.bookPrice + book5.bookPrice;
          averagePriceOfBooks = sumOfAllBooks / 5;
  
          book1.display();
          book2.display();
          book3.display();
          book4.display();
          book5.display();
  
          BookDemo.changePrice(book1);
          BookDemo.changePrice(book3);
  
          book1.display();
          book2.display();
          book3.display();
          book4.display();
          book5.display();
  
          System.out.println("The sum of all books is " + sumOfAllBooks);
          System.out.println("The average price of books is " + averagePriceOfBooks);
      }
}
