using System;
using System.Collections.Generic;

namespace GoFish
{

  public class Player
  {
    private List<int> _hand = new List<int>();
    public List<int> Hand {get => _hand; }
    public string Name {get; set;}

    public Player(string name)
    {
      Name = name;
    }

    public void GiveToHand (int card)
    {
      _hand.Add(card);
    }

  }
}
