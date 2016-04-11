using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class VisaPayment:IPayment
    {
        const int MOUNT = 23;

        private bool VerifyPassword(Card card, string password)
        {
            return card.PrivateKey == password;
        }

        private bool VerifyMount(decimal importe)
        {
            return importe <= MOUNT;
        }

        public Message Pay(decimal amount, Card card, string password)
        {
            if (!VerifyPassword(card, password))
            {
                return new Message() { Text = "El pin no es correcto" };
            }

            if (!VerifyMount(amount))
            {
                return new Message() { Text = "El importe no es correcto" };
            }

            return new Message() { Text = "Operación realizada correctamente" };
        }
    }
}
