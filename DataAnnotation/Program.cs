using System;
using System.ComponentModel.DataAnnotations;
using DataAnnotation.Model;
using System.Collections.Generic;
using System.Linq;

namespace DataAnnotation
{
    class Program
    {
       
        static void Main(string[] args)
        {
  
            User user        = new User();
            user.Name        = "AF";
            user.Age         = 6;
            user.PhoneNumber = "1234as";
            user.Email       = "test@re";

            ValidationContext context       = new ValidationContext(user, null, null);
            List<ValidationResult> results  = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult vr in results)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{vr.MemberNames.First(), 13}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"    {vr.ErrorMessage}");
                }
            } 
        }
    }
}
