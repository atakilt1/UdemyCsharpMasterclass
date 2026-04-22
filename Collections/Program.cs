using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");

            string name = employees[101];

            Console.WriteLine("Name: " + name);

            Console.ReadKey();
        }
    }
}
