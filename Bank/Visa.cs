using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Visa:Card
    {
        public Visa()
        {
            CardType = CardType.Visa;
            PrivateKey = "1111";
        }
    }
}
