using System;
using System.Collections.Generic;

namespace GoFish
{

  public class Player
  {
    private List<int> _hand = new List<int>();
    public string Name {get; set;}

    public Player(string name)
    {
      Name = name;      
    }

  }
}
