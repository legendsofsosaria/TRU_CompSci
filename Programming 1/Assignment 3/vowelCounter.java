import java.util.Scanner;

/*
 * Elizabeth Gress
 * 09/15/2023
 * 
 * Design and implement an application that repeatedly reads some text from the user, then determines and displays how many of each of the five vowels 
 * (i.e., a, e, i, o, and u) appear in the entire text. Have a separate counter for each vowel. Also count and print the number of non-vowel characters. 
 * The app should handle both lowercase and uppercase vowels. The logic must include a switch-case structure to determine which counter to increment. 
 * After the results for an input are displayed, prompt the user if they want to do another input.
 *
 */
public class vowelCounter
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        char choice;
        int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0, nonVowelCount = 0;
        
        do
        {
            System.out.println("Enter some text:");
            String inputText = scan.nextLine(); 
            
            for (int i = 0; i < inputText.length(); i++)
            {
                char ch = inputText.charAt(i);
                
                if (ch == ' ') 
                {
                    continue; // Skip whitespace characters
                }
                switch(ch)
                {
                    case 'a':
                    case 'A': aCount++;
                    break;
                    case 'e':
                    case 'E': eCount++;
                    break;
                    case 'i':
                    case 'I': iCount++;
                    break;
                    case 'o':
                    case 'O': oCount++;
                    break;
                    case 'u':
                    case 'U': uCount++;
                    break;
                    default:
                    nonVowelCount++;
                }
            }
            
            System.out.println("Number of 'A' or 'a' vowels: " + aCount);
            System.out.println("Number of 'E' or 'e' vowels: " + eCount);
            System.out.println("Number of 'I' or 'i' vowels: " + iCount);
            System.out.println("Number of 'O' or 'o' vowels: " + oCount);
            System.out.println("Number of 'U' or 'u' vowels: " + uCount);
            System.out.println("Number of non-vowels: " + nonVowelCount);
            
            System.out.print("Do you want to enter another text (y/n)? ");
            choice = scan.nextLine().charAt(0);
            
            aCount = 0;
            eCount = 0;
            iCount = 0;
            oCount = 0;
            uCount = 0;
            nonVowelCount = 0;
        }
        while (choice == 'y' || choice == 'Y');
        
        scan.close();
    }
}
