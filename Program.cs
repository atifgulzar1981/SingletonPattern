using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fromEmployee = Singleton.GetInstance();
            fromEmployee.PrintDetails("From Employee");

            var fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        }
    }
}