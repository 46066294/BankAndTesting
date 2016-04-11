using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            var card = new Visa() { CCC = "1234" };
            var payment = PaymentFactory.GetPayment(card);
            var context = new PaymentContext(payment, Write);
            //Act
            context.Pay(22, card, "1111");
            //Assert

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        static void Write(Message message)
        {
            if (null != message)
            {
                Console.WriteLine(message.Text);
            }
            Console.ReadLine();
        }
    }
}
