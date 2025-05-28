namespace Blackjack;

public class Card
{
    public string Suit { get; set; }
    public string Value { get; set; }
    public Color Color { get; set; }
    public bool IsFacedown { get; set; }
    public Card(string suit, string value)
    {
        Suit = suit;
        Value = value;
        IsFacedown = false;
        if (Suit == "\u2660" || Suit == "\u2663") Color = Colors.Black;
        else Color = Colors.Red;
    }

    public Card() { }

    // Returns an array containing possible card values
    public int[] GetCardValue()
    {
        switch (Value)
        {
            case "A": return [1, 11];
            case "10" or "J" or "Q" or "K": return [10];
            default: return [Convert.ToInt32(Value)];
        }
    }
}

