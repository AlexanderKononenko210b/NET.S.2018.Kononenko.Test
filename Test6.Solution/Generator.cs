using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public static class Generator
    {
        public static IEnumerable<T> GeneratorNumber<T>(long number, T first, T second, Func<T,T,T> func)
        {
            if (number <= 1)
                throw new ArgumentOutOfRangeException($"Argument {nameof(number)} must be more than 0");

            if (func == null)
                throw new ArgumentNullException($"Argument {nameof(func)} is null");

            if (first == null)
                throw new ArgumentNullException($"Argument {nameof(func)} is null");

            if (second == null)
                throw new ArgumentNullException($"Argument {nameof(func)} is null");

            return GetNumber(number, first, second, func);

        }

        private static IEnumerable<T> GetNumber<T>(long number, T first, T second, Func<T, T, T> func)
        {
            var firstObject = first;

            yield return firstObject;

            var secondObject = second;

            yield return secondObject;

            for (int i = 3; i <= number; i++)
            {
                var result = func(secondObject, firstObject);

                yield return result;

                firstObject = secondObject;

                secondObject = result;
            }
        }
    }
}
