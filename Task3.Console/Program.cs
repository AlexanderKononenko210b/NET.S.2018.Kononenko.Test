﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("bank");

            var broker = new Broker("broker");

            stock.CourseChange += bank.CourseChangeEventHandler;

            stock.CourseChange += broker.CourseChangeEventHandler;

            stock.Market();
        }
    }
}
