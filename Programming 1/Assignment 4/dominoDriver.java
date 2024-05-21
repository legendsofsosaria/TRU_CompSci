
/**
 * Write a description of class dominoDriver here.
 *
 * Write a test driver that creates ten random tiles (i.e., uses the default constructor) and outputs them (do not worry about duplicates). Then creates 
 * six more tiles of specific values (i.e., uses the second constructor) and outputs them. The specific tiles should include those with ‘boundary’ values 
 * such as 0 and 0, 0 and 6, 6 and 6; plus two more of your choice; plus a final tile with invalid values like 7 and 8 to demo how the app handles this. 
 * You should not need to prompt the user for anything, just hard-code the calls
 */
public class dominoDriver
{
    //------------------------------------------------------
    //Main program for user to input controls of the dominos
    //------------------------------------------------------
    public static void main(String[] args)
    {
    //---------------------------------------
    //Constructor: Create the 10 random tiles
    //---------------------------------------
    System.out.println("10 Random Tiles:");
        for (int i = 0; i < 10; i++) 
        {
            Domino randomTile = new Domino();
            System.out.println(randomTile);
        }
    System.out.println(" "); 
    //--------------------------------------------
    //Create and output 6 tiles of specific values
    //--------------------------------------------
        Domino tile1 = new Domino(0, 0);
        Domino tile2 = new Domino(0, 6);
        Domino tile3 = new Domino(6, 6);
        Domino tile4 = new Domino(1, 3);
        Domino tile5 = new Domino(4, 2);
        Domino tile6 = new Domino(7, 8);
        
        System.out.println("6 Specific Tiles:");
        System.out.println(tile1);
        System.out.println(tile2);
        System.out.println(tile3);
        System.out.println(tile4);
        System.out.println(tile5);
        System.out.println(tile6);
    }
}
