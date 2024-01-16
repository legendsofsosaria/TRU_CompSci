
/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 2
 * 01/13/2024
 */
public class Book implements PasswordLockable, Genre, Comparable<Book>
{
    private String bookCode;
    private String title;
    private double price;
    private int genre;
    private String password;
    private boolean bookIsLocked;
    
    /* Default constructor */
    public Book()
    {  
    }
    
    /* Parameterized constructor */
    public Book(String bookCode, String title, double price, int genre)
    {
        this.bookCode = bookCode;
        this.title = title;
        this.price = price;
        this.genre = genre;

        bookIsLocked = false;
    }
    
    /* Accessor for book code */
    public String getBookCode()
    {
        return bookCode;
    }
    
    /* Mutator for book code */
    public void setBookCode(String code)
    {
        /*Check if book is locked before allowing changes to book code */
        if(bookIsLocked)
        {
            System.out.println("Record is locked! Book code cannot be updated.");
        }
        else
        {
           bookCode = code; 
        }
    }
    
    /* Accessor for title */
    public String getTitle()
    {
        return title;
    }
    
    /* Mutator for title */
    public void setTitle(String title)
    {
        /*Check if book is locked before allowing changes to title */
        if(bookIsLocked)
        {
            System.out.println("Record is locked! Price cannot be updated.");
        }
        else
        {
            this.title = title;
        }
    }
    
    /* Accessor for price */
    public double getPrice()
    {
        return price;
    }
    
    /* Mutator for price */
    public void setPrice(double price)
    {
        /*Check if book is locked before allowing changes to price */
        if(bookIsLocked)
        {
            System.out.println("Record is locked! Price cannot be updated.");
        }
        else
        {
            this.price = price;
        }
    }
    
    /* Accessor for genre */
    public int getGenre()
    {
        return genre;
    }
    
    /* Mutator for genre */
    public void setGenre(int genre)
    {
        /*Check if book is locked before allowing changes to genre */
        if(bookIsLocked)
        {
            System.out.println("Record is locked! Genre cannot be updated.");
        } 
        else
        {
            if(genre >= UNCLASSIFIED && genre <= ROMANCE)
            {
                this.genre = genre;
            }
            else
            {
                System.out.println("Invalid genre. Genre not set.");
            }
        }
    }
    
    /* Mutator for password, no accessor */
    public void setPassword(String password)
    {
        this.password = password;
    }
    
    /* Checks if book is locked */
    public boolean isLocked()
    {
        return bookIsLocked;
    }
    
    /* Sets the book to locked */
    public void setBookIsLocked(boolean isLocked)
    {
        bookIsLocked = isLocked;
    }
    
    /* Method to check the password and lock the book if it matches */
    public void lock(String enteredPassword)
    {
        if (enteredPassword.equals(password))
        {
            bookIsLocked = true;
            System.out.println("Book record is successfully locked.");
        }
        else
        {
            System.out.println("Incorrect password. Book record not locked.");
        }
    }
    
    /* Method to check the password and unlock the book if it matches */
    public void unlock(String enteredPassword)
    {
        if (enteredPassword.equals(password))
        {
            bookIsLocked = false;
            System.out.println("Book record is successfully unlocked.");
        }
        else
        {
            System.out.println("Incorrect password. Book record not unlocked.");
        }
    }
    
    /* Converts the genre integer to a string */
    public String toString()
    {
        switch(genre)
        {
            case FANTASY:
                return "Fantasy";
            case SCIFI:
                return "Sci-fi";
            case ROMANCE:
                return "Romance";
            default:
                return "Unclassified";
        }
    }
    
    /* Method to compare book objects */
    public int compareTo(Book otherBook)
    {
        return Double.compare(this.price, otherBook.price);
    }
}
