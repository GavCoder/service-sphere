using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1;
            string line2;
            string name = "";
            int flag;

            Console.WriteLine("Name sorting:");
            Console.WriteLine();

            Console.Write("Enter a word: ");
            line1 = Console.ReadLine();
            line1.Trim();

            Console.Write("Enter the same letters in a different order: ");
            line2 = Console.ReadLine();
            line2.Trim();

            while (line2.Length != line1.Length)
            {
                Console.Write($"Enter the same letters, with the length of {line1.Length} in a different order: ");
                line2 = Console.ReadLine();
            }

            for (int i = 0; i < line1.Length; i++)
            {
                int counter = i;
                for (flag = 0; flag < line2.Length; flag++)
                {
                        if (line1[counter] == line2[flag])
                        {
                            name += line2[flag];
                            flag = line2.Length;
                        }
                }
            }

            Console.WriteLine();

            Console.WriteLine(name.ToUpper());
        }
    }
}
