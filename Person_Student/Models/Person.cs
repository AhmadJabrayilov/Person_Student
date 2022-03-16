using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Student.Models
{
    internal class Person
    {
        private string Name;
        private string SurName;
        private int Age;

        public string name 
        {
            get
            {
                return Name;
            }
            set
            {

                if (value.Length >= 3 && value.Length <= 30)
                {
                    Name = value;
                    Console.WriteLine(IsStartsUpper(name));
                }
                else
                {
                    Console.WriteLine("Ad min.3 max. 30 herfden ibaret olmalidir.");
                }
                if (IsStartsUpper(name) == false)
                {
                    Console.WriteLine("AD boyuk herfle bashlamalidir.");
                    return;
                }
            }
                
        }

        public string surname 
        { 
            get
            {
                return SurName;
            }

            set
            {
                if(value.Length>=3 && value.Length <= 35)
                {
                    SurName = value;
                    Console.WriteLine(IsStartsUpper(surname));
                }
                else
                {
                    Console.WriteLine("soyad min.3 max. 35 herfden ibaret olmalidir.");
                }

                if(IsStartsUpper(surname) == false)
                {
                    Console.WriteLine("Soyad boyuk herfle bashlamalidir.");
                    return;

                }
            }
        }



        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
        public Person()
        {

        }


        private bool IsStartsUpper(string Name)
        {
            foreach (char upper in Name)
            {
                if (char.IsUpper(upper))
                    return true;
            }
            return false;

        }



    }
}
