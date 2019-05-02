using System;
using System.Collections.Generic;

namespace GoFish
{
  public class Game
  {
    private List<Player> _players = new List<Player>();
    public List<Player> GetPlayerList {get => _players;}
    private Deck _newDeck = new Deck();

    public int PlayerCount()
    {
      return _players.Count;
    }

    public Game(int numPlayers)
    {
      for (int i = 0; i < numPlayers; i++) {
        _players.Add(new Player("Player " + i + 1));
      }
    }

  }
}
