using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;

            Console.Write("Please enter your age:");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100");
                Console.ReadLine();
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Sorry you are underage");
                Console.ReadLine();
            }
            else if (userAge < 21)
            {
                Console.WriteLine("You need parental consent");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Congratulations");
                Console.WriteLine("You may sign up for the event!");
                Console.ReadLine();
            }
        }
    }
}
