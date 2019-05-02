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
      List<Player> players = new List<Player>() { "Player 1", "Player 2", "Player 3" ,"Player 4" ,"Player 5"};

      CollectionAssert.AreEqual(players, newGame.GetPlayerList);
      Assert.AreEqual(5, newGame.PlayerCount());

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
