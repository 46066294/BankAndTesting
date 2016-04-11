using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Card
    {
        public string CCC { get; set; }
        public string PrivateKey { get; protected set; }
        public CardType CardType { get; protected set; }
    }
}
