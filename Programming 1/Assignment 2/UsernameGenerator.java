/*
*Write an application that prompts for and obtains a person’s first and last name (separately), then composes and displays a new username for a 
*computer account. The username is to be a string composed of the first two characters of the person’s first name, followed by the first four letters 
*of the person’s last name, followed by a two-digit random number in the range of 10 to 99. Assume that the first and last names is at least two 
*and four letters long, respectively. 
*Elizabeth Gress
*08/30/2023
*/

import java.util.Scanner;
import java.util.Random;

public class UsernameGenerator {
    public static void main(String[] args) 
    {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Please enter your first name.");
        String firstName = scanner.nextLine();

        System.out.println("Please enter your last name.");
        String lastName = scanner.nextLine();

        scanner.close();

        Random random = new Random();
        int randomNumber = random.nextInt(90) + 10;
        
        String firstNameIndex = firstName.substring(0, 2);
        String lastnamePrefix = lastName.substring(0, 4);
        String usernameString = firstNameIndex + lastnamePrefix + randomNumber;

        System.out.println("Username: " + usernameString);
    }
}