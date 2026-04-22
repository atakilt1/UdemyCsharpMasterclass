using System;
using System.Collections.Generic;

namespace Collections
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
                       
            names.Add(101, "John Doe");
            names.Add(102, "Bob Smith");
            names.Add(103, "Bob Smith");
            names.Add(104, "Flob Smith");
            names.Add(105, "Dob Smith");

            string name = names[101];

            Console.WriteLine("Name: " + name);

            //update data 
            names[102] = "Jane Smith";

            //remove item
            names.Remove(105);

            Console.WriteLine();
            //iterating over a dict
            foreach(KeyValuePair<int,string> employee in names)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            //using Employee class
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            //adding emp
            employees.Add(1, new Employee ("Jon Does", 25, 100000));
            employees.Add(2, new Employee ("Jonh Doesnt", 15, 85000));
            employees.Add(3, new Employee ("Jonh Wasnt", 45, 45000));
            employees.Add(4, new Employee ("Jonh Will", 35, 50000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named {item.Value.Name}" +
                    $", earns {item.Value.Salary} and is {item.Value.Age} years old.");
            }

            Console.ReadKey();
        }
    }
}
