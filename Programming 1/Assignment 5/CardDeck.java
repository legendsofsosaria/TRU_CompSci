import java.util.Random;
/**
 * Elizabeth Gress
 * 11/06/2023
 * 
 * Creates a deck of 52 card objects. Has functions to shuffle deck, deal cards, get the # of cards left, and append the results to a string
 */
public class CardDeck
{
    private Card[] deck;
    private int cardsLeft;
    
    /* Constructor for card deck, using nested loop of for values for suit and face */
    public CardDeck()
    {
        deck = new Card[52]; //initialize deck to hold 52 card objects
        
        int index = 0;
        
        for (int suit = 1; suit <= 4; suit++)
        {
            for (int face = 1; face <= 13; face++)
            {
                deck[index] = new Card(face, suit);
                index++;
            }
        }
        
        cardsLeft = 52;
    }
    /* Swaps cards at current index i with randomly chosen index using temp variable 
       Cards will be shuffled laying one card out at a time in a pile, with the top card on the list landing on the bottom of the pile
    */
    public void shuffleDeck()
    {
        Random random = new Random();
        
        for (int i = 0; i < deck.length; i++)
        {
            int randomIndex = random.nextInt(deck.length); //for each card at index i, generate random index in the range of the deck
            Card temp = deck[i]; //temporarily stores card at current position in variable temp
            deck[i] = deck[randomIndex]; //assigns card at randomly generated index to current position i
            deck[randomIndex] = temp; //assigns card stored at temp to the randomly chosen position
        }
        
    }
    /* Deals the card while cards left is greater than 0. Cards are dealt from the top of the pile (which would be bottom of the shuffled list) */
    public Card dealCard()
    {
        if (cardsLeft > 0)
        {
            cardsLeft --;
            
            return deck[cardsLeft];
        }
        else
            return null;
    }
    /* Returns the cards left in the deck */
    public int getCardsLeft()
    {
        return cardsLeft;
    }
    /* Appends the card to string */
    public String toString() 
    {
        String result = "";
        
        for (Card card : deck)
        {
            result += card.toString() + "\n";
        }
        
        return result;
    }
}
