import java.text.DecimalFormat;
/**
 * Elizabeth House T00738901
 * COMP 1231 Assignment 1
 * 12/06/2023 
 * Calculates and analyzes a person's BMI using metric units
 * 
 */
public class MetricUnit extends MyBMI
{
    private int centimeters;
    private double heightInMeters;
    private static final double UNDERWEIGHT_THRESHOLD = 18.5; 
    private static final double NORMAL_WEIGHT_THRESHOLD = 25.0;
    
    /* Default constructor */
    public MetricUnit()
    {
        centimeters = 0;
    }

    /* Overloaded constructor */
    public MetricUnit(String name, double weight, int centimeters)
    {
        super(name, weight);
        
        if (centimeters < 0 || weight < 0)
            throw new IllegalArgumentException("Height and weight components must be non-negative");
        
        this.centimeters = centimeters;
    }
    
    /* Accessor for centimeters */
    public int getCentimeters()
    {
        return centimeters;
    }
    
    /* Mutator for centimeters */
    public void setCentimeters(int cm)
    {
        centimeters = cm;
    }
    
    /* To calculate a BMI, divide the weight in kg by height in meters squared */
    public double calculateBMI()
    {
        heightInMeters = centimeters / 100.0;
        
        return getWeight() / Math.pow(heightInMeters, 2);
    }
    
    /* Return a string telling the user if their BMI is underweight, normal, or overweight */
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
        DecimalFormat fmt = new DecimalFormat("0.##");
        
        /* Call calculateBMI method to update height in meters before formatting */
        calculateBMI();
        
        String formattedHeight = fmt.format(heightInMeters);
        String formattedBMI = fmt.format(calculateBMI());
        
        /* Returns the string from the parent class plus the extended string */
        return super.toString() + " Height: " + formattedHeight + "m BMI: " + formattedBMI + " Result of analysis: " + analyzeBMI();
    }
}
