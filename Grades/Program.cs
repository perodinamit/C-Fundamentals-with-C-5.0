using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {

        static void GiveBookAName(ref GradeBook book) //ref  - passing by reference, bez toga nema promjene u g2
        {
            book = new GradeBook();
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(ref int number) //bez ref broj x1 je 4, s time je 5. Ali onda mora ref ići i dolje u WriteLine
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            int x1 = 4;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);


            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine(stats.Averagegrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);

        }
    }

}
 