using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();

            // Console.Write("Enter your last name: ");
            var lastName = Console.ReadLine();

            // Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());

            // Console.Write("Enter your town: ");
            var town = Console.ReadLine();

            var result = ($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
            Console.WriteLine(result);
        }
    }
}