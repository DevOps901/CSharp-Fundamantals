using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dev's Grade Book");
            
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);

            while(true)
            {                
                Console.WriteLine("Enter a Grade or enter 'q' to quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

                         
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low:N1}");             
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
                
        }
    }
}
