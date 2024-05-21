import java.util.Scanner;
import java.util.InputMismatchException;

/**
 * Write an application that separately prompts for and obtains two integer values. Calculate and display the percentage that the first number 
 * is compared to the second. For example, the values 25 and 75 would be 33.333… as a percentage.
 *
 * @author (Elizabeth Gress)
 * @version 08/20/2023
 */
public class PercentageConverter
{
    public static void main(String[] args)
    {
        int firstNumber = 0, secondNumber = 1; //Initialize a default value for both integers
        double percentage;
        
        Scanner scan = new Scanner(System.in);
        boolean validFirstInput = false, validSecondInput = false;

        while (!validFirstInput) 
        {
            try 
            {
                System.out.println("Java Percentage Converter!");
                System.out.println("Please enter an integer:");
                firstNumber = scan.nextInt();
                System.out.println("You have entered " + firstNumber);
                validFirstInput = true;
            }
            catch(InputMismatchException e) 
            {
                System.out.println("Invalid input format.");
                scan.nextLine();
            }
        }
        
        while (!validSecondInput) 
        {
            try
            {
               System.out.println("Please enter a second integer:"); 
               secondNumber = scan.nextInt();
               System.out.println("You have entered " + secondNumber);

                if(secondNumber != 0)
                {
                    percentage = ((double)firstNumber / secondNumber) * 100;
                    System.out.println("Percentage: " + percentage + "%");
                    validSecondInput = true;
                }
                else
                {
                    System.out.println("Cannot divide by 0.");
                    scan.nextLine();
                }
            }
            catch(InputMismatchException e)
            {
                System.out.println("Invalid input format.");
                scan.nextLine();
            }     
        }
        scan.close();   
    }
}