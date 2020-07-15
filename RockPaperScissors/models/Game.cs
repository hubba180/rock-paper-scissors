using System;

namespace RockPaperScissors
{
  public class Game 
  {
    public Game() 
    {
      GameObject Rock = new GameObject("Rock");
      GameObject Scissors = new GameObject("Scissors");

      Player Player1 = new Player(Rock);
      Player Player2 = new Player(Scissors);

      Console.WriteLine(Player1.playerChoice);
    }
    public string Winning(int Num)
    {
      if (Num>0){
        return "Winner";
      } else {
        return "Next Player";
      };
    }
    public void Turn()
    {

    }
  }
}