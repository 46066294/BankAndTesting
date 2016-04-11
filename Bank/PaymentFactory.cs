using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PaymentFactory
    {
        public static IPayment GetPayment(Card card)
        {
            if (card.CardType == CardType.MasterCard)
            {
                return new MasterCardPayment();
            }
            return new VisaPayment();
        }
    }
}
