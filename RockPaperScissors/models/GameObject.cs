using System;

namespace RockPaperScissors
{
  public class GameObject 
  {
    public string GameType { get; set; }
    public GameObject(string type) 
    {
      GameType = type;
    }
    public string GetGameType() {
      return GameType;
    }
  }
}