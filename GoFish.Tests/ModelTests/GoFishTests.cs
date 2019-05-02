using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish;
using System;

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
      newDeck.Reshuffle();

      var result = newDeck.CardsLeft();

      Assert.AreEqual(52, result);
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
