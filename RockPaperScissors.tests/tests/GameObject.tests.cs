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
      GameObject TestObject = new GameObject();
      Assert.AreEqual(typeof(GameObject), TestObject.GetType());
    }

    public void GetType_GameObjectSavesType_String() 
    {
      GameObject TestObject = new GameObject("Rock");
      Assert.AreEqual("Rock", GameObject.Type);
    }
  }
}