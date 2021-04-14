using System;
using System.Collections.Generic;

namespace HackerRankCollections
{
    public class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] > 37 && grades[i] % 5 > 2)
                {
                    grades[i] += (5 - grades[i] % 5);
                }
            }
            return grades;
        }
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

        }
    }
}
