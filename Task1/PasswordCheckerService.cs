using System;
using System.Linq;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        private IValidator validator;

        public PasswordCheckerService(IRepository repository, IValidator validator)
        {
            this.repository = repository;

            this.validator = validator;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            var result = validator.IsValid(password);

            if (result.Item1)
            {
                repository.Create(password);

                return Tuple.Create(true, "Password is Ok. User was created");
            }

            return result;
        }
    }
}
