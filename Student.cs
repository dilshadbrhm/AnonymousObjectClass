using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsTask
{
    internal class Student
    {
        string Name;
        string Surname;
        string Group;
        int Point;
        bool IsGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;


        }
        public void PrintInfo()
        {
            if (Point>=65)
            {
                 IsGraduated = true;
            }
            Console.WriteLine($"Name:{Name} Surname:{Surname} Group:{Group} Point:{Point} Graduated:{IsGraduated}");
        }
        public void CheckGraduation()
        {
            if (Point > 64)
            {
                Console.WriteLine("Mezun olub!");

            }
            else
            {
                Console.WriteLine("Mezun olmayib");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point >= 95 && Point <= 100)
            {
                Console.WriteLine("Yüksək Şərəf");
            }
            else if (Point >= 65 && Point <= 84)
            {
                Console.WriteLine("Adi");
            }
            else if (Point >= 85 && Point <= 94)
            {
                Console.WriteLine("Şərəf");
            }
            else
            {
                Console.WriteLine("Yoxdur");
            }
        }
    }
}
