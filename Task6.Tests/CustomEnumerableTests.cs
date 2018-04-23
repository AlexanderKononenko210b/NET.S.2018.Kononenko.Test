using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            var index = 0;

            foreach (int item in Generator.GeneratorNumber(10, 1, 1, (x, y) => x + y))
            {
                Assert.AreEqual(expected[index++], item);
            }
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            var index = 0;

            foreach (int item in Generator.GeneratorNumber(10, 1, 2, (x, y) => 6 * x - 8 * y))
            {
                Assert.AreEqual(expected[index++], item);
            }
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            var index = 0;

            foreach (double item in Generator.GeneratorNumber(10, 1.0, 2.0, (x, y) => x + y / x))
            {
                Assert.AreEqual(expected[index++], item, 0.0000000000001);
            }
        }
    }
}
