
/**
 * Elizabeth Gress
 * 11/06/2023
 * 
 * Card Deck Driver - Creates a deck of cards. Lists initial cards, lists shuffled cards, list dealt cards with # of cards left in the deck.
 */
public class CardDeckDriver
{
    public static void main(String[] args)
    {
        CardDeck deck = new CardDeck(); //create the deck of cards
        System.out.println("Initial Deck:\n" + deck.toString()); //list the initial 52 card objects to strings
        
        deck.shuffleDeck(); //shuffle the cards in the deck
        System.out.println("Shuffled Deck:\n" + deck.toString()); //reads the shuffled cards to strings
        
        System.out.println("Dealing Cards:");
        
        while (deck.getCardsLeft() > 0)
        {
            Card card = deck.dealCard(); //call the deal card function
            System.out.println("Dealt " + card.toString() + ", Cards Left: " + deck.getCardsLeft()); //deal the cards and list # left
        }
    }
}
