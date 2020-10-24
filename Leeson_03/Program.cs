using System;
using System.Collections.Generic;


namespace Leeson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentMarks();

            Console.ReadKey();
        }

        static void StudentMarks()
        {
            Dictionary<string, int> studentsMarks = new Dictionary<string, int>();

            studentsMarks.Add("Jane", 97);
            studentsMarks.Add("Maria", 52);
            studentsMarks.Add("Vito", 38);
            studentsMarks.Add("Antoine", 84);
            studentsMarks.Add("Lily", 22);

            Console.Write("Name > ");
            string name = Console.ReadLine();
            if (studentsMarks.ContainsKey(name))
                Console.WriteLine($"Student {name} mark is {studentsMarks[name]}.");
            else
                Console.WriteLine($"Student {name} doesn't exist.");
        }
    }
}
