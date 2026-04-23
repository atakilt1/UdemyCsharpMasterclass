using System;

namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                int num1 = 2;
                Console.WriteLine("Enter a number?");
                int num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); 
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
