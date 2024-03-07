import java.text.DecimalFormat;
/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 1
 * 12/06/2023
 * Calculates and analyzes a person's BMI using imperial units
 */
public class ImperialUnit extends MyBMI
{
    private int feet, inches;
    private double centimeters, heightInMeters;
    private static final double CM_PER_INCH = 2.54; /* Conversion factor from inches to centimeters */
    private static final double UNDERWEIGHT_THRESHOLD = 18.5; 
    private static final double NORMAL_WEIGHT_THRESHOLD = 25.0;
    
    /* Overloaded constructor */
    public ImperialUnit(String name, double weight, int feet, int inches)
    {
        super(name, weight);
        
        if (feet < 0 || inches < 0 || weight < 0)
            throw new IllegalArgumentException("Height and weight components must be non-negative");
        
        this.feet = feet;
        this.inches = inches;
    }
    
    /* Accessor */
    public int getFeet()
    {
        return feet;
    }
    
    /* Mutator */
    public void setFeet(int ft)
    {
        feet = ft;
    }
    
    /* Accessor */
    public int getInches()
    {
        return inches;
    }
    
    /* Mutator */
    public void setInches(int in)
    {
        inches = in;
    }
    
    /* Converts the height in cm to meters and then calculates the users BMI */
    public double calculateBMI()
    {
        int totalInches = feet * 12;
        totalInches += inches;
        centimeters = totalInches * CM_PER_INCH;
        heightInMeters = centimeters / 100;
        
        return getWeight() / Math.pow(heightInMeters, 2);
    }
    
    /* Checks the BMI using calculateBMI method, then applies a string for if the user is underweight, normal, or overweight */
    public String analyzeBMI()
    {
        double BMI = calculateBMI();
        
        if(BMI < UNDERWEIGHT_THRESHOLD)
            return "Underweight";
        else if (BMI < NORMAL_WEIGHT_THRESHOLD)
            return "Normal weight";
        
        else
            return "Overweight"; 
    }
    
    public String toString()
    {
        /* Format decimal to 2 decimal points for BMI and Height */
        DecimalFormat fmt = new DecimalFormat("0.##");
        
        /* Call calculateBMI method to update height in meters before formatting */
        calculateBMI();
        
        String formattedHeight = fmt.format(heightInMeters);
        String formattedBMI = fmt.format(calculateBMI());
        
        /* Returns the string from the parent class plus the extended string */
        return super.toString() + " Height: " + formattedHeight + "m BMI: " + formattedBMI + " Result of analysis: " + analyzeBMI();
    }
}
