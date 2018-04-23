using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Validators;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new SqlRepository();

            var validator = new SqlValidator();

            validator.Add(new NullValidator());
            validator.Add(new EmptyValidator());
            validator.Add(new LeftLengthValidator());
            validator.Add(new RightLengthValidator());
            validator.Add(new LetterValidator());
            validator.Add(new NumberValidator());

            var passwordCheckerService = new PasswordCheckerService(repository, validator);

            var result = passwordCheckerService.VerifyPassword("1privet25");

            if (result.Item1)
                System.Console.WriteLine("Password is good");
            else
                System.Console.Write(result.Item2);

        }
    }
}
