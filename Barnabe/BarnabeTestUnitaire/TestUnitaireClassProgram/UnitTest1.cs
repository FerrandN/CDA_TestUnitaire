using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestUnitaireClassProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_balanceEqualMinus20_When_CalculateShops_Then_ShouldReturnArgumentOutOfRangeException()
        {
            //arrange

            //act
            
            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { BarnabeTestUnitaire.Program.CalculeNombreDeMagasinVisite(-20); });
        }

        [TestMethod]
        public void Given_balanceEqual20_When_CalculateShops_Then_ShouldReturn5()
        {
            //arrange

            //act
            
            //assert
            Assert.AreEqual(BarnabeTestUnitaire.Program.CalculeNombreDeMagasinVisite(20),4);
        }

        [TestMethod]
        public void Given_balanceEqual0_When_CalculateShops_Then_ShouldReturn0()
        {
            //arrange

            //act
            
            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { BarnabeTestUnitaire.Program.CalculeNombreDeMagasinVisite(0); });
        }

        [TestMethod]
        public void Given_balanceEqual2_When_CalculateShops_Then_ShouldReturn5()
        {
            //arrange

            //act

            //assert
            Assert.AreEqual(BarnabeTestUnitaire.Program.CalculeNombreDeMagasinVisite(2), 1);
        }
    }
}