using System;
using System.Collections.Generic;

namespace GoFish
{
  //Deck
  //List of cards in the deck.
  //when it is created add one of every card

  //Methods
  //Get random cards
  //draw hand

  public class Deck
  {


  }

  public static class Cards
  {
    private static string[] _suits = {"Spades", "Hearts", "Diamonds", "Clubs"};
    private static string[] _cards = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

    public static string GetName(int card)
    {
      string cardName = _cards[card % 13];
      string suitName = _suits[card / 13];
      return cardName + " of " + suitName;
    }
  }
}
