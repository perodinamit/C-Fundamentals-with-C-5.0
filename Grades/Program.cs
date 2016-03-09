using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

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
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello World");

            Arrays();

           // Immutable();
           //  PassByValueAndRef();
           
            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine(stats.Averagegrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);

        }

        private static void Arrays()
        {
            float[] grades = new float[3]; //value type

            AddGrades(grades);


            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }

        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 3)
            {
                grades[0] = 91;
                grades[1] = 89.1f;
                grades[2] = 75f;
               // grades[3] = 10;
            }
            
        }

        private static void Immutable()
        {
            string name = "  Matej  ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 10, 15);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);  //reference type
            Console.WriteLine(g2.Name);

            int x1 = 4; //value type - sa F12 na int se ide u detalje, ako je struct ona je value type
            IncrementNumber(ref x1);
            Console.WriteLine(x1);
        }
    }

}
 