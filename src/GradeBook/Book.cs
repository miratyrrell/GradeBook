using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        //Creating a method to Show Statistics - highest, lowest and average grades.
        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        //all the private members together at the bottom of the class.
        private List<double> grades;
        // this value cannot be changed after object initialisation 'readonly' keyword
        private readonly string name;
        //property - different to a variable. 
        public string Name { get => name; }
    }
}