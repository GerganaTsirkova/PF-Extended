using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            var students = new Dictionary<string,List<double>>();
            for (int i = 0; i < numStudents; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                double grade = double.Parse(input[1]);
                if(!students.ContainsKey(name))
                {
                    var inner = new List<double>();
                    inner.Add(grade);
                    students.Add(name, inner);
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var student in students)
            {
                double ave = student.Value.Average();
                Console.Write($"{student.Key} -> ");
                foreach (var item in student.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {ave:f2})");
            }
        }
    }
}
