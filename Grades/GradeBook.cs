using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
         public GradeBook(string name = "There is no name")
        {
            Console.WriteLine("gradebook ctor");
            Name = name;
            _grades = new List<float>(); // -isto kao i grades = new u listi dolje
        }
     //   public override IEnumerable GetEnumerator()
      //  {
            // return _grades.GetEnumerator();
      //  }

        public override void DoSomething()
        {
            
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
            
        }

        public override void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades:");
            int i = 0;
            do
            {
                textWriter.WriteLine(_grades[i]);
                i++;
            } while (i < _grades.Count);
            textWriter.WriteLine("***********");
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Grade book compute statistics");
            GradeStatistics stats = new GradeStatistics();
            

            float sum = 0.0f;
            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
               // sum = sum + grade; - isto kao i ispod
                sum += grade;
            }

            stats.Averagegrade = sum / _grades.Count;

            return stats;
        }



        protected List<float> _grades; // protected = availabe in class and in derived class
    }
}
