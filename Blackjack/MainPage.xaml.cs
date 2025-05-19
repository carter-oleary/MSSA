using System.Threading.Tasks;

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
            // Check for player bust
            if (hand.HandValue > 21 && !hand.IsDealer) CheckWinner();
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

       private async Task StartGame()
       {
            player.ClearHand();
            dealer.ClearHand();
            player.Hit();
            dealer.Hit();
            player.Hit();
            dealer.Hit();
            AddCardsToUI(player);
            AddCardsToUI(dealer);
            state = GameState.PlayerTurn;
            UpdateUI();
            if(player.HandValue == 21 || dealer.HandValue >= 10)
            {
                await CheckBlackjack();
            }
        }

        private async Task CheckBlackjack()
        {
            dealer.Cards[1].IsFacedown = false;
            dealer.GetHandValue();
            if (dealer.HandValue == 21 && player.HandValue == 21)
            {
                AddCardsToUI(dealer);
                GameStatusLabel.Text = "Push, both blackjack!";
                bankroll += betValue;
            }
            else if(player.HandValue == 21)
            {
                AddCardsToUI(dealer);
                GameStatusLabel.Text = "Blackjack!!!";
                bankroll += (int)(betValue * 2.5);
            }
            else if(dealer.HandValue == 21)
            {
                AddCardsToUI(dealer);
                GameStatusLabel.Text = "Dealer blackjack, you lose";
                betValue = 0;
            }
            else {
                dealer.Cards[1].IsFacedown = true;
                dealer.GetHandValue();
                return;
            }
            await Task.Delay(2000);
            ResetHand();
        }

        private void ResetHand()
        {
            state = GameState.Betting;
            player.ClearHand();
            dealer.ClearHand();
            DealerCards.Children.Clear();
            PlayerCards.Children.Clear();
            betValue = 0;
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
            if (state != GameState.Betting || betValue == 0) return;
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
            AddCardsToUI(dealer);
            DealerTurn();
        }

        private void OnDoubleClicked(object sender, EventArgs e)
        {
            betValue *= 2;
            CurrentBetLabel.Text = betValue.ToString();
            OnHitClicked(sender, e);
            OnStandClicked(sender, e);
        }

        private async Task DealerTurn()
        {
            state = GameState.DealerTurn;
            // Display dealers second card
            dealer.Cards[1].IsFacedown = false;
            dealer.GetHandValue();
            AddCardsToUI(dealer);
            await Task.Delay(1000);

            // Check for hit or stand
            while(dealer.HandValue < 17 || (dealer.HandValue == 17 && dealer.NumAces > 0))
            {
                dealer.Hit();
                AddCardsToUI(dealer);
                await Task.Delay(300);
            }

            await Task.Delay(1000);
            CheckWinner();

        }

        private async Task CheckWinner()
        {
            state = GameState.EndHand;

            //Check for player or dealer busts
            if(player.HandValue > 21)
            {
                GameStatusLabel.Text = "Player busts, you lose!";
                betValue = 0;
            } else if(dealer.HandValue > 21)
            {
                GameStatusLabel.Text = "Dealer busts, you win!";
                bankroll += betValue * 2;
            } else
            {
                if(player.HandValue > dealer.HandValue)
                {
                    GameStatusLabel.Text = "You win!";
                    bankroll += betValue * 2;
                } else if(dealer.HandValue > player.HandValue)
                {
                    GameStatusLabel.Text = "You lose!";
                    betValue = 0;
                } else
                {
                    GameStatusLabel.Text = "Push!";
                }
            }
            // Auto-reset after a delay
            await Task.Delay(3000);
            ResetHand();
        }
    }

}
