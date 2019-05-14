using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();
            SayHelloWorld();
            AddNameAndGrades(book);
            WriteResults(book);
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void SayHelloWorld()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello World!!");
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", (int)stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
        }

        private static void AddNameAndGrades(IGradeTracker book)
        {
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.Name = "Fernando's Grades";
            book.Name = "My Grades";
            book.AddGrade(91);
            book.AddGrade(85.5f);
            book.AddGrade(75);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}"); 
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ":" + result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ":" + result);
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description}: {result:C}");
        }
    }
}
