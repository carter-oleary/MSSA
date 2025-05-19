namespace Blackjack
{

    public partial class MainPage : ContentPage
    {
        private enum GameState
        {
            Betting,
            PlayerTurn,
            DealerTurn,
            EndHand
        };

        Deck deck;
        Hand dealer;
        Hand player;
        int betValue;
        int bankroll;
        GameState state;
        public MainPage()
        {
            deck = new Deck();
            dealer = new Hand(deck, true);
            player = new Hand(deck);
            bankroll = 1000;
            state = GameState.Betting;
            InitializeComponent();
            UpdateUI();
        }


        private void AddCardsToUI(Hand hand)
        {
            // Clears appropriate hand
            if(hand.IsDealer) { DealerCards.Children.Clear(); }
            else PlayerCards.Children.Clear();
            // Displays all cards in hand
            CollectionView handView = new CollectionView
            {
                ItemsLayout = LinearItemsLayout.Horizontal,
                ItemTemplate = Resources["cardDataTemplateSelector"] as DataTemplate,
                ItemsSource = hand.Cards
            };
            // Updates hand value labels
            if (hand.IsDealer)
            {
                DealerCards.Children.Add(handView);
                DealerScoreLabel.Text = hand.HandValue.ToString();
            }
            else
            {
                PlayerCards.Children.Add(handView);
                PlayerScoreLabel.Text = hand.HandValue.ToString();
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            switch (state)
            {
                case GameState.Betting:
                    GameStatusLabel.Text = "Place your bet";
                    break;
                case GameState.PlayerTurn:
                    GameStatusLabel.Text = "Your turn";
                    break;
                case GameState.DealerTurn:
                    GameStatusLabel.Text = "Dealer's turn";
                    break;
                case GameState.EndHand:
                    // Game result message is set elsewhere
                    break;
            }
            // Update chip balance
            ChipsBalanceLabel.Text = $"{bankroll}";

            // Update bet amount
            CurrentBetLabel.Text = $"{betValue}";

            DealButton.IsEnabled = state == GameState.Betting && betValue > 0;
            HitButton.IsEnabled = state == GameState.PlayerTurn;
            StandButton.IsEnabled = state == GameState.PlayerTurn;
            DoubleButton.IsEnabled = state == GameState.PlayerTurn && player.Cards.Count == 2 && bankroll >= betValue;


        }

       private void StartGame()
       {
            player.ClearHand();
            dealer.ClearHand();
            player.Hit();
            dealer.Hit();
            player.Hit();
            dealer.Hit();
            AddCardsToUI(player);
            AddCardsToUI(dealer);
            DealButton.IsEnabled = false;
            HitButton.IsEnabled = true;
            StandButton.IsEnabled = true;
            DoubleButton.IsEnabled = true;
            state = GameState.PlayerTurn;
            UpdateUI();
        }

        private void OnChipClicked(object sender, EventArgs e)
        {
            if (state != GameState.Betting) return;

            Button b = (Button)sender;
            int chipVal = Convert.ToInt32(b.Text.Replace("$", ""));
            betValue += chipVal;
            bankroll -= chipVal;
            UpdateUI();
        }

        private void OnDealClicked(object sender, EventArgs e)
        {
            StartGame();
        }

        private void OnHitClicked(object sender, EventArgs e)
        {
            player.Hit();
            AddCardsToUI(player);
        }

        private void OnStandClicked(object sender, EventArgs e)
        {
            DealButton.IsEnabled = true;
            HitButton.IsEnabled = false;
            StandButton.IsEnabled = false;
            DoubleButton.IsEnabled = false;
            dealer.Cards[1].IsFacedown = false;
            dealer.GetHandValue();
            DealerScoreLabel.Text = dealer.HandValue.ToString();
            state = GameState.DealerTurn;
            AddCardsToUI(dealer);
        }

        private void OnDoubleClicked(object sender, EventArgs e)
        {
            betValue *= 2;
            CurrentBetLabel.Text = betValue.ToString();
            OnHitClicked(sender, e);
            OnStandClicked(sender, e);
        }
    }

}
