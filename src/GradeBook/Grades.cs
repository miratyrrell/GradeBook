using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Grades
    {
        public Grades(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        //Creating a method to Show Statistics - highest, lowest and average grades.
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;

            //N2 - for adding two numbers after decimal point.
            Console.WriteLine($"{name}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
            Console.WriteLine($"The average grade is {result:N2}");
        }

        //all the private members together at the bottom of the class.
        private List<double> grades;
        private string name;
    }
}