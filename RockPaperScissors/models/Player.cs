using System;

namespace RockPaperScissors 
{
  public class Player
  {
    public string playerChoice { get; set; }
    public Player(GameObject PlayerChoice)
    {
      PlayerChoice.GameType = playerChoice;
    }
  }
}