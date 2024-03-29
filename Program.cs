﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\Student.txt";
            string[] students;

            
            students = new string[] { "Agnis, Brown, 21", "Agatha, Smith, 23", "Jamaine, Campbell, 20", "Joe, Mama, 25"};
            WriteStudents(dataPath, students);
            students = ReadStudents(dataPath);
            DisplayStudents(students);
            Console.ReadKey();
        }

        static string[] ReadStudents(string dataPath)
        {
            string[] students = File.ReadAllLines(dataPath);
            return students;
        }

        static void WriteStudents(string dataPath, string[] inputNames)
        {
            File.WriteAllLines(dataPath, inputNames);
        }

        static void DisplayStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("All students:");
            Console.WriteLine();
            Console.WriteLine("First Name".PadRight(15) + "Last Name".PadRight(15) + "Description".PadRight(15));
            Console.WriteLine("----------".PadRight(15) + "---------".PadRight(15) + "-----------".PadRight(15));
            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');
                Console.WriteLine(
                    studentInfo[0].PadRight(15) + studentInfo[1].PadRight(15) + studentInfo[2].PadRight(15));
            }
        }
    }
}
