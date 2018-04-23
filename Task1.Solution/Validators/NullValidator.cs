using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution.Validators
{
    public class NullValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            return Tuple.Create(true, $"{password} is valid");
        }
    }
}
