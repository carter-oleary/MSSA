namespace Blackjack;

public class Hand
{
    public List<Card> Cards {  get; set; } 
    public int HandValue { get; set; }
    public Deck Deck { get; set; }
    public int NumAces { get; set; }
    public int AceValue { get; set; }
    public bool IsDealer { get; }

    public Hand(Deck deck, bool isDealer = false)
    {
        Cards = new List<Card>();
        Deck = deck;
        NumAces = 0;
        AceValue = 0;  
        IsDealer = isDealer;
    }

    public Card Hit()
    {
        Card c = Deck.DrawCard();
        Cards.Add(c);
        if(IsDealer && Cards.Count == 2)
        {
            Cards[1].IsFacedown = true;
        }
        GetHandValue();
        return c;
    }

    public void GetHandValue()
    {
        HandValue = 0;
        NumAces = 0;
        foreach (Card c in Cards)
        {
            if (c.IsFacedown) { continue; }
            int[] value = c.GetCardValue();
            if (value.Length > 1) { NumAces++; }
            else { HandValue += value[0]; }
         
        }
        if (NumAces > 0)
        {
            AceValue = 11 + (NumAces - 1);
            if (HandValue + AceValue > 21) AceValue = NumAces;
            HandValue += AceValue;
        }
    }

    public void ClearHand()
    {
        Cards.Clear();
        HandValue = 0;
    }
}
