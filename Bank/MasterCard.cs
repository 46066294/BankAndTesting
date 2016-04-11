using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MasterCard:Card
    {
        public MasterCard()
        {
            CardType = CardType.MasterCard;
            PrivateKey = "1111";
        }
    }
}
