import java.util.Scanner;
import java.util.InputMismatchException;
import java.text.DecimalFormat;
/*
*Write an application that reads the radius and height of a cylinder then calculates and displays the volume and surface area. Use the following formulas, 
*in which r and h represent the cylinder’s radius and height. Print the output to four decimal places. Volume = π r2 h Surface Area = 2 π r (h + r)
*Elizabeth Gress
*08/30/2023
*/
public class volumeSurfaceCalculator
{
    public static void main(String[] args) 
    {
        double radius = 0, height = 0;
        Scanner scan = new Scanner(System.in);
        boolean validFirstInput = false, validSecondInput = false;
        
        while (!validFirstInput) 
        {
            try 
            {
                System.out.println("Please enter the radius of a cylinder:");
                radius = scan.nextDouble();
                System.out.println("You have entered " + radius);
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
               System.out.println("Please enter the height of a cylinder:"); 
               height = scan.nextDouble();
               System.out.println("You have entered " + height);
               validSecondInput = true;
                
            }
            catch(InputMismatchException e)
            {
                System.out.println("Invalid input format.");
                scan.nextLine();
            }     
        }
        scan.close();
        
        double volume = Math.PI * Math.pow(radius, 2) * height;
        double surfaceArea = 2 * Math.PI * radius * (height + radius);
        
        //Format to 4 decimal places
        DecimalFormat decimalFormat = new DecimalFormat("#.####");
        String formattedVolume = decimalFormat.format(volume);
        String formattedSurfaceArea = decimalFormat.format(surfaceArea);
        
        System.out.println("Volume: " +formattedVolume);
        System.out.println("Surface Area: " + formattedSurfaceArea);
        
    }
}
