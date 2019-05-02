using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using GoFish;

namespace GoFish.Tests
{

  [TestClass]
  public class TestAddItems
  {
    [TestMethod]
    public void TestCardsGetName()
    {
      Assert.AreEqual("3 of Clubs", Cards.GetName(41));
    }

    [TestMethod]
    public void TestDeckReshuffle()
    {
      Deck newDeck = new Deck();

      var result = newDeck.CardsLeft();

      Assert.AreEqual(52, result);
    }

    [TestMethod]
    public void TestDeckGetRandomCard()
    {
      Deck newDeck = new Deck();
      var result = newDeck.GetRandomCard();

      Assert.IsFalse(newDeck.CardList.Contains(result));
    }

    [TestMethod]
    public void TestGameNewGame()
    {
      Game newGame = new Game(5);
      List<Player> players = new List<Player>();
      players.Add(new Player("Player 1"));
      players.Add(new Player("Player 2"));
      players.Add(new Player("Player 3"));
      players.Add(new Player("Player 4"));
      players.Add(new Player("Player 5"));

      for (int i = 0; i < newGame.PlayerCount() - 1; i++) {
        Assert.AreEqual(newGame.Players[i].Name, players[i].Name);
      }

      Assert.AreEqual(5, newGame.PlayerCount());
    }


    [TestMethod]
    public void TestGameDealStartingCards()
    {
      Game newGame = new Game(2);
      int player1CardCount = newGame.Players[0].Hand.Count;
      int player2CardCount = newGame.Players[1].Hand.Count;
      int deckCardCount = newGame.Deck.CardsLeft();


      Assert.AreEqual(42, deckCardCount);
      Assert.AreEqual(5, player1CardCount);
      Assert.AreEqual(5, player2CardCount);
    }



    // [TestMethod]
    // public void TestPlayerAddCard()
    // {
    //   Player player1 = new Player();
    //   Player player2 = new Player();
    //   newPlayer.AddCard(3);
    //
    //
    //   var result = newPlayer.CheckCard(3);
    //
    //   Assert.AreEqual(true, result);
    // }
  }
}
