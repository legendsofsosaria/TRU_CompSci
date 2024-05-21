import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * Elizabeth Gress
 * 11/06/2023
 * Create a separate driver class that prompts the user for the sample size,
 * then instantiates a ArrayOps object of that size and outputs
 * its contents and the lowest and highest values.
 */

public class ArrayOpsDriver {
    public static void main(String[] args) {
        boolean validInput = false;
        Scanner scanner = new Scanner(System.in);
        int size = 0; //Initialize with a default value

        while (!validInput) {
            try {
                System.out.print("Enter the size of the array: ");
                size = scanner.nextInt();
                validInput = true;
            } catch (InputMismatchException e) {
                System.out.println("Invalid input format.");
                scanner.nextLine();
            }
        }

        scanner.close();

        ArrayOps arrayOps = new ArrayOps(size); // Create the array to the size entered

        System.out.println("Array contents: " + arrayOps.toString()); // display the contents of the array
        System.out.println("Lowest value: " + arrayOps.getLowestValue()); // display lowest value
        System.out.println("Highest value: " + arrayOps.getHighestValue()); // display highest value
    }
}