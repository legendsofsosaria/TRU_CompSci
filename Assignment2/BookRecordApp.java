import java.util.Scanner;

/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 2
 * 01/13/2024
 */
public class BookRecordApp
{
    public static void main(String[] args)
    {
        Book[] bookList = new Book[4];
        
        System.out.println("Creating 4 book records: ");
        bookList[0] = new Book("F001", "Unknown Title", 0.0, Genre.UNCLASSIFIED);
        bookList[1] = new Book("F002", "Harry Potter and the Goblet of Fire", 44.97, Genre.FANTASY);
        bookList[2] = new Book("S002", "Ready Player One", 24.95, Genre.SCIFI);
        bookList[3] = new Book("R003", "Virgin River", 12.99, Genre.ROMANCE);
        
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
        System.out.println("\nSet up a password.");
        System.out.println("Enter password:");
        Scanner scan = new Scanner(System.in);
        String password = scan.next();
        System.out.println("Set up password. The password is " + password);
        
        for (Book book : bookList)
        {
            book.setPassword(password);
        }
        
        System.out.print("\nFirst book record is: ");
        System.out.print("Book Code: " + firstBook.getBookCode() + " " + "Title: " + firstBook.getTitle() + " ");
        System.out.println("Price: " + firstBook.getPrice() + " " + "Genre: " + firstBook.toString());
        
        /* Lock first book record */
        System.out.println("\nEnter the password to lock the first book record: ");
        String input = scan.next();
        firstBook.lock(input);
        
        /* Try to change price when book is locked */
        firstBook.setPrice(10.80);
        
        /* Unlock first book record */
        System.out.println("\nEnter the password to unlock the first book record: ");
        input = scan.next();
        firstBook.unlock(input);
        
        /* Change the info on first book record */
        firstBook.setTitle("The Handmaid's Tale");
        firstBook.setPrice(13.82);
        firstBook.setGenre(Genre.SCIFI);
        
        System.out.println("\nThe first book record's title, price, and genre have been updated: ");
        System.out.print("Book Code: " + firstBook.getBookCode() + " " + "Title: " + firstBook.getTitle() + " ");
        System.out.println("Price: " + firstBook.getPrice() + " " + "Genre: " + firstBook.toString());
        
        System.out.println("\nBook with the highest price:");
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
