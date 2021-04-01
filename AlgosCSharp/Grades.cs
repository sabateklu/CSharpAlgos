using System;
using System.Collections.Generic;

namespace AlgosCSharp
{
    public class Grades
    {
        public Grades()
        {
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            // input: an array of integers
            // output: an array of integers
            List<int> finalGrades = new System.Collections.Generic.List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] % 5 >= 3 && grades[i] >= 38)
                {
                    int newGrade = grades[i] + 5 - grades[i] % 5;
                    finalGrades.Add(newGrade);
                }
                else if (grades[i] % 5 < 3 || grades[i] < 38)
                {
                    finalGrades.Add(grades[i]);
                }
            }
            return finalGrades;
        }
    }
}
