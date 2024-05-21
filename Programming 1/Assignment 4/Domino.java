import java.util.Random;
/**
 * Elizabeth Gress
 * 10/11/2023
 *
 * Design a class called Domino that simulates a single tile. Each end can be represented by an integer ranging from 0 to 6. A tile is named by the words 
 * for the two values, e.g. a tile with 2 pips and 5 pips is called a “Two – Five”; a tile with no pips and 4 pips is called a “Blank – Four”; and a tile 
 * with 3 pips on both ends is called a “Double Three”. By convention, a tile is always named with the larger end value last.
 * 
 * The class requires the following methods:

 * -A constructor with no parameters that generates the two values randomly (check they conform to the value rules from the set depicted).
 * -A constructor with two parameters representing the two end values (check they conform to the value rules from the set depicted).
 * -Two get_ and set_ methods that operate on the two numeric end values (check again that the set_ methods conform to the value rules).
 * -Two get_ methods that provide the textual names for the two end values.
 * -A toString() method that returns the name for the tile in a form such as “Two – Five” or “Blank – Four” or “Double Three” that uses the two get_ methods for the textual names.
 */
public class Domino
{
    private int end1, end2;
    private String[] valueNames = {"Blank", "One", "Two", "Three", "Four", "Five", "Six"};
    private final int MAX = 6;
    private boolean isValid = true;
    
    //-----------------------------------------
    //Default constructor rolls between 0 and 6
    //-----------------------------------------
    public Domino() 
    {
        Random random = new Random();
        end1 = random.nextInt(7); 
        end2 = random.nextInt(7);
    }
    //------------------------------------
    //Constructor that validates the range
    //------------------------------------
    public Domino(int end1, int end2) 
    {
        if (end1 <= MAX && end1 >= 0 && end2 <= MAX && end2 >= 0) //validate range
        {
            this.end1 = end1;
            this.end2 = end2;
        }
        else
        {
            isValid = false;
        }
    }
    //---------
    //Gets end1
    //---------
    public int getEnd1() 
    {
        return end1;
    }
    //---------
    //Gets end2
    //---------
    public int getEnd2() 
    {
        return end2;
    }
    //---------------------------------
    //Set end1 and validate range again
    //---------------------------------
    public void setEnd1(int value) 
    {
        if (value <= MAX && value >= 0) //validate range
        {
            end1 = value;
        }
        else 
        {
            isValid = false;
        }
    }
    //---------------------------------
    //Set end2 and validate range again
    //---------------------------------
    public void setEnd2(int value) 
    {
        if (value <= 6 && value >= 0) //validate range
        {
            end2 = value;
        } 
        else 
        {
            isValid = false;
        }
    }
    //--------------------------------------------
    //Return a name from the array of string names
    //--------------------------------------------
    public String getEnd1Name() 
    {
        return valueNames[end1]; //return a name from the array
    }
    //--------------------------------------------
    //Return a name from the array of string names
    //--------------------------------------------
    public String getEnd2Name() 
    {
        return valueNames[end2]; //return a name from the array
    }
    //-----------------------------
    //Concats the names to a string
    //-----------------------------
    public String toString() 
    {
        if (!isValid)
        {
            //I wasn't sure how you wanted us to handle the invalid tile since you did not specify. Initially I had it defaulting to blank
            //but that didn't really make sense to me, so I added an option to show that the tile was not in the valid range. 
           return "Invalid";  
        }
        
       return getEnd1Name() + " - " + getEnd2Name(); 
    }

}
