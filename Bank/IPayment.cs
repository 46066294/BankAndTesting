using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IPayment
    {
        Message Pay (Decimal amount, Card card, string password);
    }
}
