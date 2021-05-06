using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VenderMachine.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnMoney()
        {
            Machineprogram machineprogram = new Machineprogram();
            Assert.AreEqual(machineprogram.ValidateDrinkSelection(3), true);
            Assert.AreEqual(machineprogram.CheckDeposit(), false);
            Assert.AreEqual(machineprogram.ReturnChange(), false);
            machineprogram.InsertCoins(100);
            machineprogram.InsertCoins(5);
            Assert.AreEqual(machineprogram.CheckDeposit(), true);
            Assert.AreEqual(machineprogram.ReturnChange(), true);

        }

        [TestMethod]
        public void ValidateDrinkSelectionFalseCase()
        {
            Machineprogram machineprogram = new Machineprogram();
            machineprogram.InsertCoins(100);
            machineprogram.InsertCoins(5);
            Assert.AreEqual(machineprogram.ValidateDrinkSelection(4), false);
        }
    }
}
