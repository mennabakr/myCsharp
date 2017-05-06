using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] marks = new int[5];
            int sum = 0;

            Console.WriteLine("Please Enter Students Names and Marks : ");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Student {0} Name Is :", i + 1);
                names[i] = Console.ReadLine();

                Console.WriteLine("Student {0} Mark Is :", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Student Names and Markes Table :");
            Console.WriteLine();
            Console.WriteLine("No\tName\tMark");
            Console.WriteLine();

            Array.Sort<string>(names);
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i + 1, names[i], marks[i]);
                sum += marks[i];
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Sum\t\t{0}", sum);
            Console.WriteLine();
            Console.WriteLine("Average\t\t{0}",sum/(double)marks.Length);

            Console.ReadKey();
        }

    }
}