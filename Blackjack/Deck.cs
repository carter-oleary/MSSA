using System.Threading.Tasks;

namespace Blackjack;
public class Deck
{
    public Stack<Card> deck = new Stack<Card>();
    private List<Card> dealtCards = new List<Card>();
    private string[] CardValues = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    private string[] Suits = { "\u2660", "\u2665", "\u2666", "\u2663" };

    public Deck()
    {
        foreach(string c in Suits)
            foreach(string s in CardValues)
            {
                Card card = new Card(c, s);
                if(!dealtCards.Contains(card))
                {
                    deck.Push(card);
                }
            }
        deck = Deck.Shuffle(deck);
        ClearHand();
    }

    private static Stack<Card> Shuffle(Stack<Card> cards)
    {
        Random r = new Random();
        int n = cards.Count;
        var tempDeck = cards.ToList<Card>();
        while(n > 1)
        {
            n--;
            int i = r.Next(n + 1);
            Card temp = tempDeck[i];
            tempDeck[i] = tempDeck[n];
            tempDeck[n] = temp; 
        }
        return new Stack<Card>(tempDeck);
    }

    public void ClearHand()
    {
        dealtCards.Clear();
    }

    // Draws the next card from the deck if possible
    public Card DrawCard()
    {
        try
        {
            Card c = deck.Pop();
            dealtCards.Add(c);
            return c;
        }
        catch (Exception e) { 
            deck = new Deck().deck;
            return deck.Pop();
        }
        
    }
}
    
