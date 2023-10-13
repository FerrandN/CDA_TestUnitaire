using FluentAssertions;
using HeroGameLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ihm_WithData_PlayerWin()
        {
            //Arrange
            FakeConsole fakeConsole = new FakeConsole();
            Ihm ihm = new Ihm(fakeConsole, new FakeDice());

            //Act
            ihm.Start();

            //Assert
            string result = fakeConsole.stringBuilder.ToString();
            result.Should().StartWith("A l'attaque : points/vie 0/15");
            result.Should().EndWith("Combat perdu: points/vie 9/0\r\n");
            result.Should().HaveLength(560);
        }

        [TestMethod]
        public void TurnMethod_DiceHeroHigherThanMonsterDice_ReturnHeroWinOnePointAndLooseZeroLifePoint()
        {
            //Arrange
            IWeather weather = Mock.Of<IWeather>();
            Game game = new Game(weather);

            //Act
            game.Turn(6, 1);

            //Assert
            if (game.Result != Result.Win)
            {
                Assert.Fail();
            }
            if(game.Hero.lifePoint != 15)
            {
                Assert.Fail();
            }
            if(game.Hero.points != 1) 
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TurnMethod_DiceHeroEqualsMonsterDice_ReturnHeroWinOnePointAndLooseZeroLifePoint()
        {
            //Arrange
            IWeather weather = Mock.Of<IWeather>();
            Game game = new Game(weather);

            //Act
            game.Turn(5, 5);

            //Assert
            if (game.Result != Result.Win)
            {
                Assert.Fail();
            }
            if (game.Hero.lifePoint != 15)
            {
                Assert.Fail();
            }
            if (game.Hero.points != 1)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TurnMethod_DiceHeroSmallerThanMonsterDice_ReturnHeroLostAndLooseDiceDifferenceAsLifePoint()
        {
            //Arrange
            IWeather weather = Mock.Of<IWeather>();
            Mock.Get(weather).Setup(m => m.WhatWeatherIsIt()).Returns(IWeather.Meteo.Tempete);
            Game game = new Game(weather);

            //Act
            game.Turn(2, 4);

            //Assert
            if (game.Result != Result.Lost)
            {
                Assert.Fail();
            }
            if (game.Hero.lifePoint != 11)
            {
                Assert.Fail();
            }
            if (game.Hero.points != 0)
            {
                Assert.Fail();
            }
        }
    }
}