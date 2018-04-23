using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SqlValidator : IValidator
    {
        public IList<IValidator> collectionValidators = new List<IValidator>();

        public void Add(IValidator validatior)
        {
            collectionValidators.Add(validatior);
        }

        public void Remove(IValidator validatior)
        {
            collectionValidators.Remove(validatior);
        }

        public Tuple<bool, string> IsValid(string password)
        {
            foreach (IValidator item in collectionValidators)
            {
                var result = item.IsValid(password);

                if (result.Item1 != true)
                    return result;
            }

           return Tuple.Create(true, $"{password} is valid");
        }
    }
}
