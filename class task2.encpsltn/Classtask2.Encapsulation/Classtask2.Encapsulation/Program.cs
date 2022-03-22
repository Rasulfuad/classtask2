using System;
using Classtask2.Encapsulation.Models;

namespace Classtask2.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User num1 = new User();

            Console.Write("Username daxil edin: ");
            string username = Console.ReadLine();

            Console.Write("Sifre daxil edin: ");
            string password = Console.ReadLine();

            Console.Write("Yasinizi daxil edin: ");
            int age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
