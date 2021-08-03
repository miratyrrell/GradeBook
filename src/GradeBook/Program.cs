using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a gradebook and add grades for each student
            var gradeBook = new Book("Scott's Grade Book");
            gradeBook.AddGrade(89.1);
            gradeBook.AddGrade(90.5);
            gradeBook.AddGrade(77.5);
            gradeBook.AddGrade(69.5);

            var gradeBook2 = new Book("Mary's Grade Book");
            gradeBook2.AddGrade(65.1);
            gradeBook2.AddGrade(80.5);
            gradeBook2.AddGrade(97.5);
            gradeBook2.AddGrade(75.5);

            var gradeBook3 = new Book("Jack's Grade Book");
            gradeBook3.AddGrade(78.3);
            gradeBook3.AddGrade(80.9);
            gradeBook3.AddGrade(67.1);
            gradeBook3.AddGrade(55.7);

            Console.WriteLine("Enter student's name to see their Grade Book: (Scott, Mary or Jack)");
            string studentName = Console.ReadLine();

            //if statement showing statistics for each student
            if(studentName == "Scott")
            {
                gradeBook.ShowStatistics();
            }
            else if(studentName == "Mary")
            {
                gradeBook2.ShowStatistics();
            }
            else if(studentName == "Jack")
            {
                gradeBook3.ShowStatistics();
            }
            else
            {
                Console.WriteLine("I am sorry, I don't recognise this name!");
            }
        }
    }
}
