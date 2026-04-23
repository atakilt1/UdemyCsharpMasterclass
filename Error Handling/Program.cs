using System;
using System.Diagnostics;

namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Debug.WriteLine("Main method is running.");

            try
            {
                int num1 = 2;
                Console.WriteLine("Enter a number?");
                int num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                int lineNumber = GetExceptionLineNumber(ex);
                Console.WriteLine($"Exception thrown at line: {lineNumber}");

                Console.WriteLine("Error: " + ex.Message);
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);

            PrintWithFinally();

            Console.ReadKey();
            
        }

        static int GetExceptionLineNumber(Exception ex)
        {
            // The 'true' parameter is crucial - it tells .NET to capture file info
            var stackTrace = new StackTrace(ex, true);

            // Get the frame where the exception originated
            var frame = stackTrace.GetFrame(0);

            // Returns 0 if no line number info is available
            return frame.GetFileLineNumber();
        }

        static void PrintWithFinally()
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            finally { Console.WriteLine("Finally executed."); }              
        }
    }
}
