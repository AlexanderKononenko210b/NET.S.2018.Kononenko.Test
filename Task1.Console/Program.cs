using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;
using Task1.Solution.Validators;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new SqlRepository();

            IValidator[] validator = new IValidator[6] { new NullValidator(), new EmptyValidator(), new LeftLengthValidator(),
                new RightLengthValidator(), new LetterValidator(), new NumberValidator()};

            var passwordCheckerService = new PasswordCheckerService(repository, validator);

            var result = passwordCheckerService.VerifyPassword("1privet25");

            if (result.Item1)
                System.Console.WriteLine("Password is good");
            else
                System.Console.Write(result.Item2);

        }
    }
}
