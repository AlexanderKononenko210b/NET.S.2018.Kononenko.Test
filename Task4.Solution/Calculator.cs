using System;
using System.Collections.Generic;
using System.Linq;
using Task4.Solution;

namespace Task4
{
    public class Calculator
    {
        public double CalculateAverage(IList<double> values, ICalculator<double> calculateMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return calculateMethod.Calculat(values);
        }

        public double CalculateAverage(IList<double> values, Func<IList<double>, double> calculateDelegate)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return calculateDelegate(values);
        }
    }
}
