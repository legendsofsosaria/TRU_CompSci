import java.math.BigDecimal;
/**
 * Elizabeth House T00738901
 * COMP 1231 Assignment 2
 * 01/16/2024
 * Source for info on BigDecimal: https://www.geeksforgeeks.org/bigdecimal-class-java/
 */
public class BookRecordApp
{
    public static void main(String[] args)
    {
        Book[] bookList = new Book[4];
        
        System.out.println("Creating 4 book records: ");
        bookList[0] = new Book("F001", "Unknown Title", new BigDecimal("0.0"), Genre.UNCLASSIFIED);
        bookList[1] = new Book("F002", "Harry Potter and the Goblet of Fire", new BigDecimal("44.97"), Genre.FANTASY);
        bookList[2] = new Book("S002", "Ready Player One", new BigDecimal("24.95"), Genre.SCIFI);
        bookList[3] = new Book("R003", "Virgin River", new BigDecimal("12.99"), Genre.ROMANCE);
        
        Book firstBook = bookList[0];
        Book secondBook = bookList[1];
        Book thirdBook = bookList[2];
        Book fourthBook = bookList[3];
        
        System.out.print("Book Code: " + firstBook.getBookCode() + " " + "Title: " + firstBook.getTitle() + " ");
        System.out.println("Price: " + firstBook.getPrice() + " " + "Genre: " + firstBook.toString());
        
        System.out.print("Book Code: " + secondBook.getBookCode() + " " + "Title: " + secondBook.getTitle() + " ");
        System.out.println("Price: " + secondBook.getPrice() + " " + "Genre: " + secondBook.toString());
        
        System.out.print("Book Code: " + thirdBook.getBookCode() + " " + "Title: " + thirdBook.getTitle() + " ");
        System.out.println("Price: " + thirdBook.getPrice() + " " + "Genre: " + thirdBook.toString());
        
        System.out.print("Book Code: " + fourthBook.getBookCode() + " " + "Title: " + fourthBook.getTitle() + " ");
        System.out.println("Price: " + fourthBook.getPrice() + " " + "Genre: " + fourthBook.toString());
        
        /* Set up a password for book records */
        String password = "FredAndGeorge";
        System.out.println("\nSet up password. The password is " + password);
        System.out.println("A password has been set up.");
        
        for (Book book : bookList)
        {
            book.setPassword(password);
        }
        
        System.out.print("\nFirst book record is: ");
        System.out.print("Book Code: " + firstBook.getBookCode() + " " + "Title: " + firstBook.getTitle() + " ");
        System.out.println("Price: " + firstBook.getPrice() + " " + "Genre: " + firstBook.toString() + "\n");
        
        /* Lock first book record */
        System.out.println("Lock the first book record using " + password);
        firstBook.lock(password);
        
        /* Try to change price when book is locked */
        System.out.println("Attempt to change price of the first book record.");
        firstBook.setPrice(new BigDecimal("10.80"));
        
        /* Attempt to unlock with wrong password */
        String wrongPassword = "Lilac";
        System.out.println("Unlock the first book record using a wrong password.");
        firstBook.unlock(wrongPassword);
        
        /* Unlock with proper password */
        System.out.println("Unlock the first book record using " + password);
        firstBook.unlock(password);
        
        /* Change the info on first book record */
        firstBook.setTitle("The Handmaid's Tale");
        firstBook.setPrice(new BigDecimal("13.82"));
        firstBook.setGenre(Genre.SCIFI);
        
        System.out.println("The first book record's title, price, and genre have been updated: ");
        System.out.print("Book Code: " + firstBook.getBookCode() + " " + "Title: " + firstBook.getTitle() + " ");
        System.out.println("Price: " + firstBook.getPrice() + " " + "Genre: " + firstBook.toString());
        
        System.out.println("\nList of books with the highest price:");
        Book highestPriceBook = findHighestPriceBook(bookList);
        System.out.print("Book Code: " + highestPriceBook.getBookCode() + " " + "Title: " + highestPriceBook.getTitle() + " ");
        System.out.println("Price: " + highestPriceBook.getPrice() + " " + "Genre: " + highestPriceBook.getGenre());
    }
    
    private static Book findHighestPriceBook(Book[] bookList) 
    {
        Book highestPriceBook = bookList[0];
        
        for (Book book : bookList) 
        {
            if (book.compareTo(highestPriceBook) > 0) 
            {
                highestPriceBook = book;
            }
        }
        return highestPriceBook;
    }
}
