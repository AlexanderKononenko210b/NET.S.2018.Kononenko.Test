using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        private IEnumerable<IValidator> validator;

        public PasswordCheckerService(IRepository repository, IEnumerable<IValidator> validator)
        {
            this.repository = repository;

            this.validator = validator;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            foreach (IValidator item in validator)
            {
                var result = item.IsValid(password);

                if (!result.Item1)
                    return result;
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
