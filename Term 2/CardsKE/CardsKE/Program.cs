using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsKE
{
    public class BaseCard
    {
        protected String rank;
        protected int value;
        protected String suit;
        public static String[] RANKS = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public static String[] SUITS = { "C", "S", "H", "D" };

        //public BaseCard()
        //{
        //    Console.WriteLine("Create your card.");
        //    Console.WriteLine("Select a rank: ");
        //    setRank(Console.ReadLine());
        //    Console.WriteLine("Select a suit: ");
        //    setSuit(Console.ReadLine());
        //}

        public void printCard()
        {
            Console.WriteLine("+---------+");
            Console.WriteLine(String.Format("| {0}{1,2}     |", this.suit, this.rank));
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine(String.Format("|    {0,2} {1} |", this.rank, this.suit));
            Console.WriteLine("+---------+");
        }

        public void setRank(String rank) 
        {
            this.rank = rank;
        }

        public void setSuit(String suit)
        {
            this.suit = suit;
        }

        public void setValue()
        {
            if (this.rank.Equals("A"))
            {
                this.value = 1;
            }
            else if (this.rank.Equals("J"))
            {
                this.value = 11;
            }
            else if (this.rank.Equals("Q"))
            {
                this.value = 12;
            }
            else if (this.rank.Equals("K"))
            {
                this.value = 13;
            }
            else
            {
                this.value = int.Parse(this.rank);
            }
        }
    }

    public class PosCard : BaseCard //Positional card
    {
        private bool pos;

        public PosCard()
        {
            pos = false;
        }

        public PosCard(String rank, String suit)
        {
            this.rank = rank;
            this.suit = suit;
            pos = false;
        }
        public new void printCard()
        {
            if (pos == true)
            {
                Console.WriteLine("+---------+");
                Console.WriteLine(String.Format("| {0}{1,2}     |", this.suit, this.rank));
                Console.WriteLine("|         |");
                Console.WriteLine("|         |");
                Console.WriteLine("|         |");
                Console.WriteLine("|         |");
                Console.WriteLine("|         |");
                Console.WriteLine(String.Format("|    {0,2} {1} |", this.rank, this.suit));
                Console.WriteLine("+---------+");
            }
            else
            {
                Console.WriteLine("+---------+");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("|XXXXXXXXX|");
                Console.WriteLine("+---------+");
            }
        }

        public void flip()
        {
            if (this.pos == true)
            {
                this.pos = false;
            }
            else
            {
                this.pos = true;
            }
        }
    }

    public class Deck
    {
        private PosCard[] cards = new PosCard[52];

        public Deck()
        {
            this.createDeck();
        }

        public void createDeck()
        {
            int index = 0;
            foreach (String suit in BaseCard.SUITS)
            {
                foreach (string rank in BaseCard.RANKS)
                {
                    PosCard card = new PosCard(rank, suit);
                    cards[index] = card;
                    index++;
                }

            }
        }

        public void printDeck()
        {
            foreach(PosCard card in cards)
            {
                card.printCard();
                card.flip();
                card.printCard();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.createDeck();
            deck.printDeck();
            Console.ReadKey();
        }
    }
}
