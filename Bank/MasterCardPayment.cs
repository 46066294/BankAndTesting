﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MasterCardPayment:IPayment
    {
        public Message Pay(decimal amount, Card card, string password)
        {
            throw new NotImplementedException();
        }
    }
}
