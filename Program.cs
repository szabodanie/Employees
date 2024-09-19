﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        public static List<Employer> employers = new List<Employer>();
        public static void feladat3()
        {
            Console.WriteLine("Az összes dolgozó neve: ");
            foreach (var item in employers)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void feladat4()
        {
            int max = employers[0].Salary;
            int id = 0;

            foreach (var item in employers)
            {
                if (item.Salary > max)
                {
                    max = item.Salary;
                    id  = item.Id;
                }
            }
            Console.WriteLine($"A legjobban kereső dolgoző id: {id}, Keresete: {employers[id-1].Name}");
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");
            for (int i = 0; i <100; i++)
            {
                Employer emp = new Employer(sr.ReadLine());
                employers.Add(emp);
            }
            feladat3();
            feladat4();
        }
    }
}
