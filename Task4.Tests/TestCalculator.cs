using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task4;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_With_Interface()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            var meanCalculator = new MeanCalculator();

            double actual = calculator.CalculateAverage(values, meanCalculator);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_With_Delegate()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            var meanCalculator = new MeanCalculator();

            double actual = calculator.CalculateAverage(values, meanCalculator.Calculat);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_With_Interface()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            var medianCalculator = new MedianCalculator();

            double actual = calculator.CalculateAverage(values, medianCalculator);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_With_Delegate()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            var medianCalculator = new MedianCalculator();

            double actual = calculator.CalculateAverage(values, medianCalculator.Calculat);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}