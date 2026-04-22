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
            employees.Add(103, "Bob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");

            string name = employees[101];

            Console.WriteLine("Name: " + name);

            //update data 
            employees[102] = "Jane Smith";

            //remove item
            employees.Remove(105);

            Console.WriteLine();
            //iterating over a dict
            foreach(KeyValuePair<int,string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            Console.ReadKey();
        }
    }
}
