using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PaymentContext
    {
        readonly IPayment _payment;
        readonly Action<Message> _callBack;

        public PaymentContext(IPayment payment, Action<Message> callBack)
        {
            if (null == payment)
            {
                throw new ArgumentNullException();
            }
            _payment = payment;
            _callBack = callBack;
        }

        public void Pay(Decimal amount, Card card, string password)
        {
            var message = _payment.Pay(amount, card, password);
            if (null !=_callBack)
            {
                _callBack(message);
            }
        }
    }
}
