using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook() // default constructor, bez parametara - ctor
        {
            grades = new List<float>(); // -isto kao i grades = new u listi dolje
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            

            float sum = 0.0f;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
               // sum = sum + grade; - isto kao i ispod
                sum += grade;
            }

            stats.Averagegrade = sum / grades.Count;

            return stats;
        }

        public string Name;


        private List<float> grades;
    }
}
