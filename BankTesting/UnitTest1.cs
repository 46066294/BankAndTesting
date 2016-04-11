using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace BankTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void should_sort_this_ascending()
        {
            //Arrange
            var card = new Visa() { CCC = "1234" };
            var payment = PaymentFactory.GetPayment(card);

            //Act
            var message = payment.Pay(20, card, "1111");

            //Assert
            Assert.AreEqual(message.Text, "Operación realizada correctamente");
            //context.Pay(22, card, "1111");

        }
    }
}
