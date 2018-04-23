using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution.Validators
{
    public class LetterValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            return Tuple.Create(true, $"{password} is valid");
        }
    }
}
