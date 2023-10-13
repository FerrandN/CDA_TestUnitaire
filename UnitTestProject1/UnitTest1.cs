using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.Result = game.Turn(6, 1);

            //Assert
            if (game.Result != game.Result.Win)
            {

            }
        }
    }
}
