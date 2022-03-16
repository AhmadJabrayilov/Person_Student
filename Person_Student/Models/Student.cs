using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Student.Models
{
    internal class Student:Person
    {
        private int Point;

        public Student(int Point)
        {
            this.Point = Point;
        }


        public int point 
        {
            get
            {
                return Point;
            }

            set
            {
                if (value >=0 && value<=100)
                    Point = value;
                else
                {
                    Console.WriteLine("Point 0-100 araliginda olmalidir.");
                }
            }
        }



        public Student()
        {

        }

    }
}
