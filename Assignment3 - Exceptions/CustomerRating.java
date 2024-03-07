import java.util.Scanner;
import java.io.*;

/**
 * Elizabeth House T00738901
 * COMP 1231 Assignment 3
 * 02/06/2024
 */
public class CustomerRating
{
    private static final int MAX_RECORDS = 5;
    private Customer[] surveyRecords;
    private int size;
    String fileName = "rating.txt";
    
    public CustomerRating() 
    {
        surveyRecords = new Customer[MAX_RECORDS];
        size = 0;
    }
    
    /* Verifies array bounds before adding customer record to the array. If not, throw out of bounds exception.
       Verifies the rating is valid between 1 and 10. If not, throws illegal argument exception. */
    public void addRecord(int age, double rating) throws ArrayIndexOutOfBoundsException
    {
        if (size < MAX_RECORDS)
        {
            if (rating >= 1 && rating <= 10)
            {
               surveyRecords[size++] = new Customer(age, rating); 
            }
            else
            {
                throw new IllegalArgumentException("Invalid rating. Please enter a rating between 1 and 10.");
            }
        }
        else
        {
            throw new ArrayIndexOutOfBoundsException("Array out of bounds. Maximum records reached.");
        }
    }
    
    /* Displays the list of records in the array to the console in formatted columns */
    public void displayRecords()
    {
        System.out.println("Most updated list of customer ratings");
        System.out.println("---------------------------------------");
        System.out.println("Age \t \t \t Rating");
        System.out.println("---------------------------------------");
        
        for (Customer record : surveyRecords) 
        {
            if (record != null) 
            {
                System.out.printf("%-20d %-20.2f%n", record.getAge(), record.getRating());
            }
        }
    }
    
    /* Calculates the average ages and ratings from the array and displays to console */
    private void calculateAndDisplayAverages()
    {
        double totalAge = 0.00, totalRating = 0.00;
        
        for (Customer record : surveyRecords)
        {
            if (record != null)
            {
                totalAge += record.getAge();
                totalRating += record.getRating();
            }
        }
        
        double averageAge = totalAge / size;
        double averageRating = totalRating / size;
        
        System.out.printf("Average Age: %.2f%n", averageAge);
        System.out.printf("Average Rating: %.2f%n", averageRating);
    }
    
    /* Reads the file and throws exception if the file does not exist */
    public void readFile(String fileName) throws IOException 
    {
        try
        {
            BufferedReader reader = new BufferedReader(new FileReader(fileName));
            String line;
            
            while ((line = reader.readLine()) != null)
            {
                String[] data = line.split("\t");
                int age = Integer.parseInt(data[0].trim());
                double rating = Double.parseDouble(data[1].trim());
                addRecord(age, rating);
            }
            
            reader.close();
        }
        catch (IOException iox)
        {
            System.err.println("Problem reading " + fileName);
            iox.printStackTrace();
        }
    }
    
    /* Writes the the data from the array to a file formatted with a [,] between the age and rating */
    private void writeFile(String fileName) throws IOException 
    {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(fileName)))
        {
            for (Customer record : surveyRecords)
            {
                if (record != null)
                {
                    writer.write(record.getAge() + "\t" + record.getRating());
                    writer.newLine();
                }
            }
        }
    }
    
    /* Main part of program for user input. Checks for array bounds exception and number format exceptions. Properly formats numbers to display.
       Runs the methods to display the records, calculate averages, and write to the file. Handles exception reading or writing to the file. 
       Closes the scanner. */
    public static void main(String[] args)
    {
        CustomerRating customerRating = new CustomerRating();
        Scanner scan = new Scanner(System.in);
        
        try 
        {
            customerRating.readFile("rating.txt");
            customerRating.displayRecords();
            
            while (true) 
            {
                System.out.print("Enter age[integer], followed by one [,] key, then rating[decimal number] (or type '!' to exit): ");
                String input = scan.nextLine();
                
                if (input.equals("!")) 
                {
                    break;
                }
                
                String[] data = input.split(",");
                
                try
                {
                    int age = Integer.parseInt(data[0].trim());
                    double rating = Double.parseDouble(data[1].trim());
                    customerRating.addRecord(age, rating);
                }
                catch (NumberFormatException e)
                {
                    System.err.println("Invalid number format. Please enter valid age and rating.");  
                }
                catch (IllegalArgumentException e) 
                {
                    System.out.println("Invalid rating. Please enter a rating between 1 and 10.");
                }
                catch (ArrayIndexOutOfBoundsException e)
                {
                    System.err.println("Array out of bounds. Maximum records reached.");
                }
            }
            
            customerRating.displayRecords();
            customerRating.calculateAndDisplayAverages();
            customerRating.writeFile("rating.txt");
        }
        catch (IOException e)
        {
            System.err.println("Error reading/writing file: " + e.getMessage());
            e.printStackTrace();
        }
        finally
        {
            scan.close();
        }
    }
}
