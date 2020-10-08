using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();

            // HOMEWORKS FOR NEXT LESSON
            Homework1(); // Array
            Homework2(); // Stack
            Homework3(); // Queue
            Homework4();

            Console.ReadKey();
        }

        static void Task1()
        {
            string[] names = { "Folg", "Vito", "Freidine", "Ilan", "Auguste" };
            DateTime[] bday = new DateTime[names.Length];
            bday[0] = new DateTime(2000, 07, 26);
            bday[1] = new DateTime(2000, 03, 22);
            bday[2] = new DateTime(2000, 11, 02);
            bday[3] = new DateTime(2000, 07, 09);
            bday[4] = new DateTime(2000, 01, 10);

            Console.Write("Please enter an index (0-4) > ");
            int index = int.Parse(Console.ReadLine());

            int day = bday[index].Day;
            string when = "beginning";
            if (day > 10)
                when = "mid";
            if (day > 20)
                when = "end";


            Console.WriteLine($"{names[index]}'s birthday is in {when} of {NameOfMonth(bday[index].Month)}");
        }
        static string NameOfMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "February";
            if (month == 3) return "March";
            if (month == 4) return "April";
            if (month == 5) return "May";
            if (month == 6) return "June";
            if (month == 7) return "July";
            if (month == 8) return "August";
            if (month == 9) return "September";
            if (month == 10) return "October";
            if (month == 11) return "November";
            if (month == 12) return "December";
            else return "Unknown";
        }

        static void Task2()
        {
            string sentence = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = sentence.Split(" ");
            string longest = "";
            for(int i = 0; i<words.Length; i++)
            {
                if (words[i].Length > longest.Length)
                    longest = words[i];
            }
            Console.WriteLine(longest);
        }

        static void Task3()
        {
            string sentence = "Display the pattern like pyramid using the alphabet.";
            string[] words = sentence.Split(" ");
            for (int i = words.Length - 1; i >= 0; i--)
                Console.Write($"{words[i]} ");
        }

        static void Homework1() // Array
        {
            int[] array = new int[10]; // Declaring
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = i + 1; // Adding items
            }

            Console.WriteLine("Specify an item (integer number) and we'll check if it's in the array:");
            int item = int.Parse(Console.ReadLine());
            bool exist = false;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == item) // Checking existence
                    exist = true;
            Console.WriteLine($"{item} is in the array is {exist}");

            Console.WriteLine("The array contains:");
            foreach(var member in array)
            {
                Console.Write($"{member}  "); // Displaying
            }
            Console.WriteLine();
        }

        static void Homework2() // Stack
        {
            Stack<int> stack = new Stack<int>(); // Declaring

            for (int i = 1; i < 11; i++)
                stack.Push(i); // Adding items

            Console.WriteLine("Specify an item (integer number) and we'll check if it's in the stack:");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine($"{item} is in the stack is {stack.Contains(item)}"); // Checking existence

            Console.WriteLine("The stack contains:");
            while (stack.Count != 0)
            {
                int var = stack.Pop();
                Console.Write($"{var}  "); // Displaying
            }
            Console.WriteLine();
        }

        static void Homework3() // Queue
        {
            Queue<int> queue = new Queue<int>(); // Declaring

            for (int i = 1; i < 11; i++)
                queue.Enqueue(i); // Adding items

            Console.WriteLine("Specify an item (integer number) and we'll check if it's in the queue:");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine($"{item} is in the queue is {queue.Contains(item)}"); // Checking existence

            Console.WriteLine("The queue contains:");
            while (queue.Count != 0)
            {
                int var = queue.Dequeue();
                Console.Write($"{var}  "); // Displaying
            }
            Console.WriteLine();
        }

        static void Homework4() // List
        {
            List<int> list = new List<int>(); // Declaring
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 1); // Adding items
            }

            Console.WriteLine("Specify an item (integer number) and we'll check if it's in the list:");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine($"{item} is in the list is {list.Contains(item)}"); // Checking existence

            Console.WriteLine("The list contains:");
            foreach (var member in list)
            {
                Console.Write($"{member}  "); // Displaying
            }
            Console.WriteLine();
        }
    }
}
