using System;
using System.Collections.Generic;
using System.Linq;

namespace cards1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool bcontinue = true;

            while (bcontinue) {
                Console.Clear();
                Console.WriteLine("Lets Play Cards..");

                //make deck
                //shuffle
                Deck deck = new Deck();
                deck.Shuffle();

                //make players
                int playercount = 4;
                Player[] players = new Player[playercount];
                for (int idx=0; idx<playercount; idx++) {
                    players[idx] = new Player(idx>0, idx); //idx==0:human
                } 

                //deal cards
                int cardsperhand = 5;
                for (var iplayer=0; iplayer<playercount; iplayer++) {
                    for (var icard=0; icard<cardsperhand; icard++) {
                        players[iplayer].AddCard(deck.DealCard());
                    }
                }
                // Console.WriteLine("{0} 0-based Cards remain in the deck", deck.cardCount.ToString());

                //show hands
                for (var iplayer=0; iplayer<playercount; iplayer++) {
                    players[iplayer].ShowHand();
                }

                //draw/discard
                DrawCards(players, deck);


                for (var iplayer=0; iplayer<playercount; iplayer++) {
                    players[iplayer].ShowHand();
                }

                //score
                ScoreHands();


                //repeat
                bcontinue = Repeat();
            }


            void DrawCards(Player[] players, Deck deck){
                Random rPlayer = new Random();
                int iplayer = rPlayer.Next(4);                
                Console.WriteLine("You are player #{0}", iplayer);
                Console.Write("Enter the # of the cards to discard.\nExample: 013 would discard cards 0, 1, & 3: ", iplayer);
                string discard = "";
                discard = Console.ReadLine();
                discard = Console.ReadLine();
                foreach (char c in discard) {
                    Console.WriteLine("Discarding Card {0}", c);
                    int icard = int.Parse(c.ToString());
                    if (icard<5 && icard >=0) {
                        players[iplayer].DiscardAndAdd(icard, deck.DealCard());
                    }
                }
            }

            void ScoreHands(){

            }

            // from :
            // http://www.codinghomework.com/c-poker-game-pt0-demonstration-of-the-finished-poker-application/



            
            bool Repeat(){
                Console.Write("Repeat [n]/y: ");
                string resp = Console.ReadLine();
                if (resp == "y")
                    return true;
                return false;
            }


        }





        class Deck
        {
            private PlayingCard[] cards;
            public int cardCount;

            public Deck()
            {
                cardCount = 52;
                cards = new PlayingCard[cardCount];
                var index = 0;

                for (var suit = 0; suit <= 3; suit++)
                {
                    for (var rank = 0; rank < 13; rank++)
                    {
                        // Console.WriteLine("Creating card {0} {1} {2}", index, rank, suit);
                        cards[index++] = new PlayingCard(rank, suit);
                    }
                }
                Console.WriteLine("Deck Created");
            }


            Random rShuffle = new Random();
            //  Based on Java code from wikipedia:
            //  http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
            public void Shuffle()
            {
                for (int n = this.cards.Length - 1; n > 0; --n)
                {
                    int k = rShuffle.Next(n+1);
                    PlayingCard temp;
                    temp = this.cards[n];
                    this.cards[n] = this.cards[k];
                    this.cards[k] = temp;
                }
                Console.WriteLine("Deck Shuffled");
            }

            public PlayingCard DealCard() {
                cardCount--;
                // Console.WriteLine("Dealing " + this.cards[cardCount].ToString());
                return this.cards[cardCount];
            }


        }



        class Player {
            private PlayingCard[] hand = new PlayingCard[5];
            private PlayingCard[] sortedhand = new PlayingCard[5];
            int handCount;

            private bool isComputer;
            private bool isTurn;
            private int turnOrder;            

            public Player(bool isComp, int tOrder) {
                this.isComputer = isComp;
                this.turnOrder = tOrder;
                this.handCount = 0;

                Console.WriteLine("Player {0} Created", tOrder);
            }

            public void AddCard(PlayingCard toAdd) {
                this.handCount++;
                hand[this.handCount-1] = toAdd;
                // Console.WriteLine("Player {0} Adding Card {1}", this.turnOrder.ToString(), toAdd.ToString());
            }
            public void DiscardAndAdd(int icard, PlayingCard pcard) {
                Console.WriteLine("Player {0} Card {1}: {2} ===> {3}", this.turnOrder.ToString(), icard, this.hand[icard].ToString(), pcard.ToString());
                this.hand[icard] = pcard;
            }

            // public void SortHand() {

            // var queryPlayer = from card in hand
            //                   orderby card.MyValue
            //                   select hand;

            // var queryComputer = from hand in computerHand
            //                     orderby hand.MyValue
            //                     select hand;

            // var index = 0;
            // foreach(var element in queryPlayer.ToList())
            // {
            //     sortedPlayerHand[index] = element;
            //     index++;
            // }

            // index = 0;
            // foreach (var element in queryComputer.ToList())
            // {
            //     sortedComputerHand[index] = element;
            //     index++;
            // }


            // }

            public void ShowHand() {
                Console.WriteLine("Player {0} Hand:", this.turnOrder);
                for (int idx=0; idx<this.handCount; idx++) {
                   Console.WriteLine("  Card {0}: {1}, ", idx, hand[idx].ToString());
                }
            }



        }


        public class PlayingCard : IComparable<PlayingCard> {

            private int value;
            private int suit;

            public int Value => value;
            public string ValueName => ValueToName(value);

            public int Suit => suit;
            public string SuitName => SuitToName(suit);


            //properties
            public int MySuit { get {return suit;}  set {suit = value;} }
            public int MyValue { get {return value;}  set {this.value = value;} }


            public PlayingCard(int value, int suit) {
                this.value = value;
                this.suit = suit;
            }

            private string ValueToName(int n) {
                switch (n) {
                    case 0:
                        return "Ace";
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        return (n+1).ToString();
                    case 10:
                        return "Jack";
                    case 11:
                        return "Queen";
                    case 12:
                        return "King";
                    default:
                        throw new ArgumentException("Unrecognized card value.");

                }
            }

            private string SuitToName(int s) {
                switch (s)
                {
                    case 0:
                        return "Clubs";
                    case 1:
                        return "Diamonds";
                    case 2:
                        return "Spades";
                    case 3:
                        return "Hearts";
                    default:
                        throw new ArgumentException("Unrecognized card suit");
                }
            }

            public int CompareTo(PlayingCard other)
            {
                int result = this.Suit.CompareTo(other.Suit);

                if (result != 0)
                    return result;

                return this.Value.CompareTo(other.Value);
            }

            public override string ToString()
            {
                return String.Format("{0} of {1}", ValueName, SuitName);
            }
        }




    }
}
