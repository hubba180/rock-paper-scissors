using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using RockPaperScissors;

namespace RockPaperScissors.tests 
{
  [TestClass]
  public class RockPaperScissorsTests 
  {
    [TestMethod]
    public void GameObjectConstructor_CreatesInstanceOfGameObject_GameObject()
    {
      GameObject TestObject = new GameObject("rock");
      Assert.AreEqual(typeof(GameObject), TestObject.GetType());
    }

    [TestMethod]
    public void GetType_GameObjectSavesType_String() 
    {
      string rock = "Rock";
      GameObject TestObject = new GameObject(rock);
      Assert.AreEqual("Rock", TestObject.GetGameType());
    }
    [TestMethod]
    public void GetType_WinningTheGame_String()
    {
      int winning = 1;
      Program TestMethod = new Program();
      Assert.AreEqual("Winner", TestMethod.Winning(winning));
    }
  }
}