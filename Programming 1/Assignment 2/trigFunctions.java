import java.util.Scanner;
import java.util.InputMismatchException;
/*
*Write an application that reads the values for the adjacent and opposite lengths as decimal values, then determines and displays the values for 
*the sin, cos, and tan. This should prompt for and read each of the two values individually.
*Elizabeth Gress
*08/30/2023
*/
public class trigFunctions
{
    public static void main(String[] args) 
    {
        double adjacentSide = 0, oppositeSide = 0;
        Scanner scan = new Scanner(System.in);
        boolean validFirstInput = false, validSecondInput = false;
        
        while (!validFirstInput) 
        {
            try 
            {
                 System.out.println("Please enter the length of the adjacent side:");
                adjacentSide = scan.nextDouble();
                System.out.println("You have entered " + adjacentSide);
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
               System.out.println("Please enter the length of the opposite side:"); 
               oppositeSide = scan.nextDouble();
               System.out.println("You have entered " + oppositeSide);
               validSecondInput = true;
                
            }
            catch(InputMismatchException e)
            {
                System.out.println("Invalid input format.");
                scan.nextLine();
            }     
        }
        scan.close();
        
        double hypotenuseSide = Math.sqrt((Math.pow(adjacentSide, 2)) + (Math.pow(oppositeSide, 2)));
        double sinValue = oppositeSide/hypotenuseSide, cosValue = adjacentSide/hypotenuseSide, tanValue = oppositeSide/adjacentSide;
        
        System.out.println("Sine: " + sinValue);
        System.out.println("Cosine: " + cosValue);
        System.out.println("Tangent: " + tanValue);
        
    }
}
