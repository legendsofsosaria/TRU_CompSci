import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * Write an application that prompts for and obtains a value representing a whole number of seconds,
 * then displays the equivalent amount of time as a combination of hours, minutes, and seconds. 
 * For example, 9999 seconds is equivalent to 2 hours, 46 minutes, and 39 seconds.
 *
 * @author (Elizabeth Gress)
 * @version 08/20/2023
 */
public class TimeConverter
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        boolean validInput = false;
        int timeInSeconds = 0; // Initialize with a default value

        while (!validInput) 
        {
            try 
            { 
                System.out.println("Java time converter!");
                System.out.println("Please enter a time in seconds:");
                timeInSeconds = scan.nextInt();
                System.out.println("You have entered " + timeInSeconds);
                validInput = true;
            }
            catch(InputMismatchException e)
            {
                System.out.println("Invalid input format.");
                scan.nextLine();
            }
        }

        scan.close();  
        int hours = timeInSeconds / 3600; //1 hour
        int minutes = (timeInSeconds % 3600) / 60; // 1 minute 
        int seconds = timeInSeconds % 60;
        System.out.println("Converted time: " + hours + " hours, " + minutes + " minutes, " + seconds + " seconds.");    
    }
}