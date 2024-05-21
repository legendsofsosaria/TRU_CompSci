/**
 * Elizabeth Gress
 * 10/06/2023
 * 
* Design and implement a class called Monkey, which represents a monkey climbing along a vertical vine in the jungle. The monkey can only climb for one 
* unit of distance at a time. The direction in which it is climbing can be either up or down. The monkey can decide to change direction (i.e., if it was 
* climbing up, then it will now be climbing down; and vice-versa). Monkey requires a toString method to return both the current position and the direction 
* climbing to the driver so it can be output. No set or get methods are required for this question.
 */
public class Monkey
{
    private int position;
    private boolean isClimbingUp;
    
    //-----------------------------------------------------------------------------
    //Constructor: Set initial position of the monkey to 0 and direction to up
    //-----------------------------------------------------------------------------
    
    public Monkey()
    {
        position = 0;
        isClimbingUp = true;
    }
    
    //------------------------------------------------------
    //Move the monkey by 1 unit in direction it is climbing
    //------------------------------------------------------
    public void climbUp()
    {        
        if (isClimbingUp)
            position++;
        else
            position--;
    }
    
    //-------------------------------------
    //Reverse direction monkey is climbing
    //-------------------------------------
    public void reverseDirection()
    {
        isClimbingUp = !isClimbingUp;
    }
    
    //-----------------------------------------------------------------
    //Return a string expression of the monkeys position and direction
    //-----------------------------------------------------------------
    public String toString()
    {
        String direction = isClimbingUp ? "up" : "down";
        
        return "Monkey is at position " + position + " and climbing " + direction;
    }
}
