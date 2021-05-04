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
            machineprogram.InsertCoins(100);
            machineprogram.InsertCoins(5);
            Assert.AreEqual(machineprogram.ValidateDrinkSelection(3), true);
            Assert.AreEqual(machineprogram.Deposit, 105);
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
