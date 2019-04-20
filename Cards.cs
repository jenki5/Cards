using System.Collections.Generic;
using System;
namespace Cards.Custom{
    class Card{
        public string stringVal;
        public string Suit;
        public int Val;
        public string ModStringVal{
            get{
                return stringVal;
            }
            set{
                stringVal = value;
            }
        }
        public string ModSuit{
            get{
                return Suit;
            }
            set{
                Suit = value;
            }
        }
        public int ModVal{
            get{
                return Val;
            }
            set{
                Val = value;
            }
        }
    }
    class Deck{
        public List<Card> Cards = new List<Card>();
        public Deck(){
            string[] suites = {"Diamonds", "Clubs", "Hearts", "Spades"};
            int y = 0;
            foreach(string suit in suites){
                for (int i = 1; i < 14; i++){
                Cards.Add(new Card());
                if(i == 1){
                    Cards[i-1+y].stringVal = "Ace";
                }
                if(i == 11){
                    Cards[i-1+y].stringVal = "Jack";
                }
                if(i == 12){
                    Cards[i-1+y].stringVal = "Queen";
                }
                if(i == 13){
                    Cards[i-1+y].stringVal = "King";
                }
                if(i > 1 && i < 11){
                    string numAsString = i.ToString();
                    Cards[i-1+y].stringVal = numAsString;
                }
                Cards[i-1+y].Suit = suit;
                Cards[i-1+y].Val = i;
                Console.WriteLine($"The card is a {Cards[i-1].stringVal} of {suit}.");
                }
                y += 13;
            }
        }
        public Card Deal(){
            Card Dealt = Cards[0];
            Cards.RemoveAt(0);
            return Dealt;
        }
        
        public void Shuffle(){
            Random rand = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int randCard = rand.Next(0, Cards.Count);
                Card temp = Cards[randCard];
                Cards[randCard] = Cards[i];
                Cards[i] = temp;
            }
        }
    }
    class Player{
        public string Name;
        public List<Card> Hand = new List<Card>();
        public Player(string name){
            Name = name;
        }
        public Card Draw(Deck deck){
            Card draw = deck.Deal();
            Hand.Add(draw);   
            return draw;          

        }
    }
}