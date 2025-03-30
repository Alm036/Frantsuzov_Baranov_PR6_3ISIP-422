using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;

namespace BankTests2
{
    [TestClass]
    public class BankAccountTests2
    {
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 7.44;
            double creditAmount = 4.55;
            double expected = 11.99;
            BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]

        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = -1;
            double creditAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Credit(creditAmount));

        }
    }
}
