using System;
using System.Collections.Generic;

namespace GoFish
{
  //Deck
  //List of cards in the deck.
  //when it is created add one of every card

  //Methods
  //Get random card and remove from the deck
  //draw hand

  public class Deck
  {
    private List<int> _cards = new List<int>();

    public List<int> CardList { get => _cards; }

    public int GetRandomCard()
    {
      Random rnd = new Random();
      int index = rnd.Next(0, _cards.Count - 1);
      int pulledCard = _cards[index];
      _cards.Remove(index);
      return pulledCard;
    }

    public Deck()
    {
      Reshuffle();
    }

    public void Reshuffle()
    {
      _cards.Clear();
      for (int i = 0; i < 52; i++) {
        _cards.Add(i);
      }
    }

    public int CardsLeft()
    {
      return _cards.Count;
    }

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
