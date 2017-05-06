using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "student Averags";
            int[] studentMarks = new int[5];
            string[] studentNames = new string[5];
            int sum = 0;

            Console.WriteLine("Enter Students Names and Markes");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            
            for(int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine("Input Student {0} Name : ", i + 1);
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Input Student {0} Mark :", i + 1);
                studentMarks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Student Marks Table");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("No\tName\tMark");
            Console.WriteLine();

            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i + 1, studentNames[i], studentMarks[i]);
                sum += studentMarks[i];
            }
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Sum\t\t{0}", sum);
            Console.WriteLine("Average\t\t{0}", sum / (double)studentMarks.Length);





            Console.ReadKey();
        }
    }
}
