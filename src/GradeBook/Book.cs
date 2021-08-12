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

        public void AddLetterGrade (char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;
                    
            }

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
                /*when we run the application there will be an error
                here we specify where the error occured*/
                throw new ArgumentException($"Invalid {nameof(grade)}");
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


            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

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