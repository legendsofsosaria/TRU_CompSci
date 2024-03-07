
/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 1
 * 12/13/2023
 * Create a driver class named BMIApp with a single array reference of the MyBMI class. Since no user input is needed in the driver, 
 * you can write some code statements to store in the array with three objects using the Imperial system and an additional three other objects 
 * using the Metric system (a total of six objects).
 */
public class BMIApp
{
    public static void main(String[] args)
    {
        MyBMI[] bmiList = new MyBMI[6];
        
        bmiList[0] = new ImperialUnit("Caitlin", 45.2, 5, 6);
        bmiList[1] = new ImperialUnit("Iris", 58.9, 5, 4);
        bmiList[2] = new ImperialUnit("Cisco", 68.9, 5, 4);
        bmiList[3] = new MetricUnit("Nora", 63.5, 155);
        bmiList[4] = new MetricUnit("Barry", 55.2, 183);
        bmiList[5] = new MetricUnit("Joe", 79.1, 185);
        
        /* Prints list for size of array */
        for (MyBMI bmi : bmiList)
        {
            System.out.println(bmi);
        }
    }
}
