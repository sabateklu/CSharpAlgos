using System;

namespace AlgosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("trying to push this to github");

            System.Collections.Generic.List<int> grades = (Grades.gradingStudents(new System.Collections.Generic.List<int>()
                {
                4, 73, 67, 38, 33
                }
                ));

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
