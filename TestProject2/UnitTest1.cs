using BouteilleAgain;
using BouteilleAgain.ExceptionBouteille;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BottleIsOpen_OpenBottle_ShouldReturnFalseAndBottleIsOpen()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(true,5,50);

            //ACT
            bool result = bouteille.Open();
            //ASSERT
            Assert.IsFalse(result);
            Assert.IsTrue(bouteille.EstOuverte);
        }

        [TestMethod]
        public void BottleIsClosed_OpenBottle_ShouldReturnTrueAndBottleIsOpen()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(false, 5, 50);

            //ACT
            bool result = bouteille.Open();
            //ASSERT
            Assert.IsTrue(result);
            Assert.IsTrue(bouteille.EstOuverte);
        }

        [TestMethod]
        public void BottleIsClosed_CloseBottle_ShouldReturnFalseAndBottleIsClosed()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(false, 50, 50);

            //ACT
            bool result = bouteille.Close();

            //ASSERT
            Assert.IsFalse(result);
            Assert.IsFalse(bouteille.EstOuverte);
        }

        [TestMethod]
        public void BottleIsOpenWith5L_RemplirBottle5L_ShouldReturnContenuEqual10()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(true, 5, 50);

            //ACT
            bool result = bouteille.Remplire(5);
            //ASSERT
            Assert.AreEqual(bouteille.ContenuEnL, 10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BottleIsOpenWith50L_RemplirBottle5L_ShouldReturnFalseAndContenueEnLEqualsTo50()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(true, 50, 50);

            //ACT
            bool result = bouteille.Remplire(5);

            //ASSERT
            Assert.IsFalse(result);
            Assert.AreEqual(bouteille.ContenuEnL, 50);
        }

        [TestMethod]
        public void BottleIsOpenWith5L_ViderBottle5L_ShouldReturnTrue()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(true, 5, 50);

            //ACT
            bool result = bouteille.Vider(5);

            //ASSERT
            Assert.IsTrue(result);
            Assert.AreEqual(bouteille.ContenuEnL, 0);
        }

        [TestMethod]
        public void BottleIsOpenWith5L_ViderBottle6L_ShouldReturnFalse()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(true, 5, 50);

            //ACT
            bool result = bouteille.Vider(6);

            //ASSERT
            Assert.IsFalse(result);
            Assert.AreEqual(bouteille.ContenuEnL, 5);
        }

        [TestMethod]
        public void Bottle_GenerateBottleWithMoreContenuThanContenance_ShouldReturnException()
        {

            //Arrange
            Bouteille b;

            //ACT


            //ASSERT
            Assert.ThrowsException<BouteilleContenantInferieurAContenue>(() => b = new Bouteille(true, 50, 5));
        }

        public void Bottle_GenerateBottleWithContenuNegativeValue_ShouldReturnException()
        {
            Bouteille b;

            //ACT


            //ASSERT
            Assert.ThrowsException<ValueLessThanZero>(() => b = new Bouteille(true, -50, 5));
        }

        public void Bottle_GenerateBottleWithContenanceNegativeValue_ShouldReturnException()
        {
            Bouteille b;

            //ACT


            //ASSERT
            Assert.ThrowsException<ValueLessThanZero>(() => b = new Bouteille(true, -50, -5));
        }
    }
}