using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook("Matej");
            //FileStream stream = null;
            //StreamReader reader = null;

            try
            {
                using (FileStream stream = File.Open("grade.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }

            //string[] lines = File.ReadAllLines("grade.txt");
            //foreach (string line in lines)
            //{
            //    float grade = float.Parse(line);
            //    book.AddGrade(grade);
            //}
            Console.WriteLine("-------------------");
            }
            catch (FileNotFoundException ex)
            {
                
                Console.WriteLine("Could not locate the file!");
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No access!!!");
                return;
            }


            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.AddGrade(30);

            book.WriteGrades(Console.Out);
            // book.Name = ""; - exception

            try
            {
                Console.WriteLine("Please enter a name for the book");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Invalid name");
            }
            

            GradeStatistics stats = book.ComputeStatistics();



            Console.WriteLine(stats.Averagegrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("{0} {1}",stats.LetterGrade, stats.Description);





            //book.NameChanged += OnNameChanged;
            //book.NameChanged += OnNameChanged;
            //book.NameChanged += OnNameChanged2;
            //book.NameChanged -= OnNameChanged;

            //book.Name = "Anina knjiga";
            //WriteNames(book.Name);

            //Arrays();

            // Immutable();
            //  PassByValueAndRef();

        }

    //    private static void OnNameChanged2(object sender, NameChangedEventArgs args)
    //    {
    //        Console.WriteLine("****");
    //    }

    //    private static void OnNameChanged(object sender, NameChangedEventArgs args)
    //    {
    //        Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
    //}

    //    private static void WriteBytes(int value)
    //    {
    //        byte[] bytes = BitConverter.GetBytes(value);
    //        WriteByteArray(bytes);
    //    }


    //    private static void WriteBytes(float value)
    //    {
    //        byte[] bytes = BitConverter.GetBytes(value);
    //        WriteByteArray(bytes);
    //    }

    //    //extract method
    //    private static void WriteByteArray(byte[] bytes)
    //    {
    //        foreach (byte b in bytes)
    //        {
    //            Console.Write("0x{0:X}", b);
    //        }
    //        Console.WriteLine();
    //    }

    //    private static void WriteNames(params string[] names)
    //    {
    //        foreach (string name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //    }

        //static void GiveBookAName(ref GradeBook book) //ref  - passing by reference, bez toga nema promjene u g2
        //{
        //    book = new GradeBook();
        //    book.Name = "The Gradebook";
        //}

        //static void IncrementNumber(ref int number) //bez ref broj x1 je 4, s time je 5. Ali onda mora ref ići i dolje u WriteLine
        //{
        //    number += 1;
        //}

        //private static void Arrays()
        //{
        //    float[] grades = new float[3]; //value type

        //    AddGrades(grades);


        //    foreach (float grade in grades)
        //    {
        //        Console.WriteLine(grade);
        //    }

        //}

        //private static void AddGrades(float[] grades)
        //{
        //    if (grades.Length >= 3)
        //    {
        //        grades[0] = 91;
        //        grades[1] = 89.1f;
        //        grades[2] = 75f;
        //    }

        //}

        //private static void Immutable()
        //{
        //    string name = "  Matej  ";
        //    name = name.Trim();

        //    DateTime date = new DateTime(2015, 10, 15);
        //    date = date.AddHours(25);

        //    Console.WriteLine(date);
        //    Console.WriteLine(name);
        //}

        //private static void PassByValueAndRef()
        //{
        //    GradeBook g1 = new GradeBook();
        //    GradeBook g2 = g1;

        //    GiveBookAName(ref g2);  //reference type
        //    Console.WriteLine(g2.Name);

        //    int x1 = 4; //value type - sa F12 na int se ide u detalje, ako je struct ona je value type
        //    IncrementNumber(ref x1);
        //    Console.WriteLine(x1);
        //}
    }

}
 