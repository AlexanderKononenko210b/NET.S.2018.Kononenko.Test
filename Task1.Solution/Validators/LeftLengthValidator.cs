using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution.Validators
{
    public class LeftLengthValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");

            return Tuple.Create(true, $"{password} is valid");
        }
    }
}
