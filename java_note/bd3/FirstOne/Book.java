package bd3.FirstOne;

public class Book {
      private String bookName;
      private String bookAuthor;
      protected int bookPrice;
      private String datePrinted;
      protected static int sumOfAllBooks;
      protected static int averagePriceOfBooks;

      public Book() {
            this.bookName = "";
            this.bookAuthor = "";
            this.bookPrice = 0;
            this.datePrinted = "";
      }

      public Book(String bookName, String bookAuthor, int bookPrice, String datePrinted) {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookPrice = bookPrice;
            this.datePrinted = datePrinted;
      }

      public Book(Book book) {
            this.bookName = book.bookName;
            this.bookAuthor = book.bookAuthor;
            this.bookPrice = book.bookPrice;
            this.datePrinted = book.datePrinted;
      }

      public void display() {
            System.out.println("Book name: " + bookName);
            System.out.println("Book author: " + bookAuthor);
            System.out.println("Book price: " + bookPrice);
            System.out.println("Date printed: " + datePrinted);
      }

      public static void changePrice(Book book) {
            book.bookPrice = book.bookPrice + 10;
      }

      public static int getSumOfAllBooks() {
            return sumOfAllBooks;
      }

      public static int getAveragePriceOfBooks() {
            return averagePriceOfBooks;
      }
}
