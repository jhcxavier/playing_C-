using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Joao's Book");
            // book.AddGrade(98.9);
            // book.AddGrade(90.5);
            // book.AddGrade(100.0);
            
            var rounds = 1;
            for(var i = 0; i<rounds; i++)
            {
                System.Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q"){
                    break;
                }
                
                try{
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    rounds++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    rounds++;
                }
            }
            // while(!done)
            // {
            //     System.Console.WriteLine("Enter a grade or 'q' to quit");
            //     var input = Console.ReadLine();
            //     var grade = double.Parse(input);
            //     book.AddGrade(grade);
            // }




            var stats = book.GetStatistics();

            System.Console.WriteLine($"The lowest grade  is {stats.Low}");
            System.Console.WriteLine($"The higher score is {stats.High}");
            Console.WriteLine($"The avarage grade is {stats.Avarage:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter:N1}");
        }
    };
   
}
