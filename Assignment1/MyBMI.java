/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 1
 * 11/22/2023
 * Parent class for BMI program. Takes name and weight of the user in kg. Contains abstract methods for analyzing and calculating BMI
 * to be overriden in the individual unit classes.
 */
public abstract class MyBMI
{
    private String name;
    private double weight;
        
    /* Parameterized constructor */
    public MyBMI(String n, double w) 
    {
        name = n;
        weight = w;
    }
    
    /* Accessor */
    public String getName() 
    {
        return name;
    }
    
    /* Mutator */
    public void setName(String name) 
    {
        
        this.name = name;
    }
    
    /* Accessor */
    public double getWeight() 
    {
        return weight;
    }
    
    /* Mutator */
    public void setWeight(double weight) 
    {
        this.weight = weight;
    }
    
    /* Calculate BMI method declared as abstract, to ensure method is overridden in derived classes */
    public abstract double calculateBMI();
    
    /* Analyze BMI method declared as abstract, to ensure method is overriden in derived classes */
    public abstract String analyzeBMI();
    
    /* Returns name and weight to string */
    public String toString() 
    {
        
        return "Name: " + name + " Weight: " + weight + "kg";
    }
}
