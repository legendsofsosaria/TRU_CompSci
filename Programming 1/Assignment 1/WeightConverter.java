import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * Write an application that converts a weight in pounds into kilograms (1 pound equals 0.45359237 kilograms). 
 * Prompt for and obtain the pounds amount from the user as a decimal value and report the equivalent amount in kilograms.
 *
 * @author (Elizabeth Gress)
 * @version 08/20/2023
 */
public class WeightConverter
{
    public static void main(String[] args)
    {
        double weightKilos, weightPounds = 0; //Initialize with a default value
        final double CONVERSION_FACTOR = 0.45359237;
        boolean validInput = false;
        Scanner scan = new Scanner(System.in);
        
        while (!validInput) 
        {
            try 
            { 
                System.out.println("Java weight converter!");
                System.out.println("Please enter a weight in pounds:");
                weightPounds = scan.nextDouble();
                System.out.println("You have entered " + weightPounds);
                validInput = true;
            }
            catch(InputMismatchException e)
            {
                System.out.println("Invalid input format.");
                scan.nextLine();
            }
        }
        scan.close();
        weightKilos = weightPounds * CONVERSION_FACTOR;
        System.out.println("Weight in kilos: " + weightKilos); 
    }
}
