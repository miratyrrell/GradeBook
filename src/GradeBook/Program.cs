using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeBook = new Book("Scott's Grade Book");

            var gradeBook2 = new Book("Mary's Grade Book");

            var gradeBook3 = new Book("Jack's Grade Book");


            Console.WriteLine("Enter student's name: (Scott, Mary or Jack)");
            string studentName = Console.ReadLine();

            Book selected = null;

            /*if statement showing statistics for each student.
            Scott's name could be spelled in any way, all case sensitivity will be ignored.
            The rest of the names have to be spelled either beginning with small or capital letter*/
            if (string.Equals(studentName, "Scott", StringComparison.OrdinalIgnoreCase))
            {
                selected = gradeBook;
                /*When we enter input it will be a string.
                To turn it into a double we need to use double.Parse static method*/
                while (true)
                {
                    Console.WriteLine("Enter a grade or 'q' to quit and calculate lowest, highest, and average grades.");
                    var input = Console.ReadLine();

                    if (input == "q")
                    {
                        break;
                    }

                    try
                    {
                        var grade = double.Parse(input);
                        gradeBook.AddGrade(grade);
                    }

                    //we are going to try to catch the error/exception and give a message to the user
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if(studentName == "Mary" || studentName == "mary")
            {
                selected = gradeBook2;

                while (true)
                {
                    Console.WriteLine("Enter a grade or 'q' to quit and calculate lowest, highest, and average grades.");
                    var input = Console.ReadLine();

                    if (input == "q")
                    {
                        break;
                    }
                    try
                    {
                        var grade = double.Parse(input);
                        gradeBook2.AddGrade(grade);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if(studentName == "Jack" || studentName == "jack")
            {
                selected = gradeBook3;

                while (true)
                {
                    Console.WriteLine("Enter a grade or 'q' to quit and calculate lowest, highest, and average grades.");
                    var input = Console.ReadLine();

                    if (input == "q")
                    {
                        break;
                    }
                    try
                    {
                        var grade = double.Parse(input);
                        gradeBook3.AddGrade(grade);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("I am sorry, I don't recognise this name!");
            }

            if (selected != null)
            {
                var name = selected.Name;
                Console.WriteLine($"{name}");

                var stats = selected.GetStatistics();

                Console.WriteLine($"The highest grade is {stats.High:N2}");
                Console.WriteLine($"The lowest grade is {stats.Low:N2}");
                Console.WriteLine($"The average grade is {stats.Average:N2}");
                Console.WriteLine($"The letter grade is '{stats.Letter}'");
            }
        }
    }
}