using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string validateEmail = Console.ReadLine();

            if (IsValidEmail(validateEmail))
            {
                Console.WriteLine("Awesome, that was a valid email address!");
            }
            else
            {
                Console.WriteLine("Bummer! That's not a valid email.");
            }

            Main(args);
        }

        private static bool IsValidEmail(string validateEmail)
        {
            try{
                MailAddress email = new MailAddress(validateEmail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
