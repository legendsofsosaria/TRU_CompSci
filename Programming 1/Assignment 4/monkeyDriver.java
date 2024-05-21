import java.util.Scanner;
/**
 * Elizabeth Gress
 * 10/06/2023
 * 
 * Write an interactive test driver that instantiates a Monkey, then allows the user to manipulate it with simple commands like Output (to see the position
 * and direction), Climb, Reverse, Exit ... single letters work just fine. All output must be via the driver not methods within Monkey. You should use this
 * driver to create screenshot exhibits for a number of scenarios (e.g. output original state, climb a few times, output, climb a few more times, output, 
 * reverse, output, climb, output, reverse, output, etc.).
 */
public class monkeyDriver
{
    //-----------------------------------------------------------------
    //Main program for user to input controls of the monkey
    //-----------------------------------------------------------------
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        Monkey monkey = new Monkey(); //Instatiates monkey object
        boolean isRunning = true;
        
        System.out.println("Monkey Climbing Simulator");
        
        while (isRunning)
        {
            System.out.println("Options:");
            System.out.println("O: Output");
            System.out.println("C: Climb");
            System.out.println("R: Reverse");
            System.out.println("E: Exit");
            System.out.print("Enter your choice (O/C/R/E): ");
            
            char choice = scan.nextLine().charAt(0);
            
            switch (choice) //Response to user input
            {
                //handle capital and lower case in the event user ignores case
                case 'O':
                    System.out.println(monkey.toString());
                    break;
                case 'o':
                    System.out.println(monkey.toString());
                    break;
                case 'C':
                    monkey.climbUp();
                    System.out.println("Monkey has climbed one unit.");
                    break;
                case 'c':
                    monkey.climbUp();
                    System.out.println("Monkey has climbed one unit.");
                    break;
                case 'R':
                    monkey.reverseDirection();
                    System.out.println("Monkey has reversed direction.");
                    break;
                case 'r':
                    monkey.reverseDirection();
                    System.out.println("Monkey has reversed direction.");
                    break;
                case 'E':
                    System.out.println("Exiting the Monkey Climbing Simulator.");
                    scan.close();
                    isRunning = false;
                    System.exit(0);
                case 'e':
                    System.out.println("Exiting the Monkey Climbing Simulator.");
                    scan.close();
                    isRunning = false;
                    System.exit(0);
                default:
                    System.out.println("Invalid choice. Please enter a valid option.");
            }
        }
    }
}
