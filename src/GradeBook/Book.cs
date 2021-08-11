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
            //if statement is a Branching statement
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
            
        }

        //Creating a method to Show Statistics - highest, lowest and average grades.
        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            //this could be done with foreach or for statement
            for(var index = 0; index < grades.Count; index++)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }

            result.Average /= grades.Count;

            return result;
        }

        //all the private members together at the bottom of the class.
        private List<double> grades;
        // this value cannot be changed after object initialisation if we use 'readonly' keyword
        //readonly removed for test purposes, now we can set a new name
        private string name;
        //property - different to a variable. 
        public string Name { get => name; set => name = value; }
    }
}