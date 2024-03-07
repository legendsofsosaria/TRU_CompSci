
/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 3
 * 01/31/2024
 */
public class Customer
{
    private int age;
    private double rating;

    /* Constructor for objects of class Customer */
    public Customer()
    {
        /* initialize instance variables */
        age = 0;
        rating = 0.0;
    }
    
    /* Overloaded constructor */
    public Customer(int age, double rating) 
    {
        this.age = age;
        this.rating = rating;

    }
    
    public int getAge()
    {
        return age;
    }
    
    public double getRating()
    {
        return rating;
    }
}
