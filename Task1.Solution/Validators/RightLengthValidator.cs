using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution.Validators
{
    public class RightLengthValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");

            return Tuple.Create(true, $"{password} is valid");
        }
    }
}
