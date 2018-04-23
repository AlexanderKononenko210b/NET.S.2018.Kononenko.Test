using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Solution;

namespace Task4.Tests
{
    public class MeanCalculator : ICalculator<double>
    {
        public double Calculat(IList<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
