using System;
using Person_Student.Models;
namespace Person_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Ahmed";
            Console.WriteLine(st1.name);
            st1.surname = "Jabrayilov";
            Console.WriteLine(st1.surname);
            st1.point = 75;
            Console.WriteLine(st1.point);   


        }
    }
}
