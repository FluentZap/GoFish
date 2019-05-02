using System;
using System.Collections.Generic;

namespace GoFish
{

  public static class CurrentGame
  {

    public static Game ThisGame;
    static CurrentGame()
    {
      ThisGame = new Game(2);
    }
  }



  public class Game
  {
    private List<Player> _players = new List<Player>();
    public List<Player> Players {get => _players;}
    private Deck _newDeck = new Deck();
    public Deck Deck {get => _newDeck;}
    public int CurrentTurn {get; set;}

    public void NextTurn()
    {
      CurrentTurn++;
      if (CurrentTurn >= _players.Count)
      {
        CurrentTurn = 0;
      }
    }

    public Player GetNextPlayer()
    {
      if (CurrentTurn == 0)
      {
        return _players[0];
      }
      else
      {
        return _players[1];
      }
    }

    public int PlayerCount()
    {
      return _players.Count;
    }

    public Game(int numPlayers)
    {
      for (int i = 0; i < numPlayers; i++)
      {
        _players.Add(new Player("Player " + (i + 1)));
      }
      Deal();
    }

    private void Deal()
    {

      foreach (Player player in _players)
      {
        for (int i = 0; i < 5; i++)
        {
          int card = _newDeck.GetRandomCard();
          player.GiveToHand(card);
        }
      }
    }
  }
}
