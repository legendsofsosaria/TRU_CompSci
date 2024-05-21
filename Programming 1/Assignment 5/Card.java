
/**
 * Elizabeth Gress
 * 11/06/2023
 * 
 * Creates card object and appends face and suit name to a string.
 */
public class Card
{
    private int face;
    private int suit;
    
    private static String[] faceNames = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
    private static String[] suitNames = {"Clubs", "Diamonds", "Hearts", "Spades"};
    public Card(int f, int s)
    {
        face = f;
        suit = s;
    }

    public String toString()
    {
        return faceNames[face - 1] + " of " + suitNames[suit - 1];
    }
}
