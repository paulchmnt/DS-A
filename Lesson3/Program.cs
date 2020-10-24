using System;
using System.Collections.Generic;


namespace Leeson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StudentMarks(); // Demo
            SortedDict(); // Demo

            // WORK IN CLASS
            MenuList(); // Task 1
            Occurences(); // Task 2
            Removing(); // Task 3

            // HOMEWORKS
            Minesweeper(); // 1 */
            Phonebook(); // 2

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
            studentsMarks.Add("Nina", 58);
            studentsMarks.Add("Alex", 72);
            studentsMarks.Add("Clara", 28);
            studentsMarks.Add("Jean", 95);
            studentsMarks.Add("Dédé", 2);

            while (true)
            {
                Console.Write("Name (enter 'exit' to exit) > ");
                string name = Console.ReadLine();

                if (name == "exit")
                    break;

                if (studentsMarks.ContainsKey(name)) // if (studentMarks.TryGetValue(name, out value)) other method
                    Console.WriteLine($"Student {name} mark is {studentsMarks[name]}."); // Student {name} mark is {value}. other method
                else
                    Console.WriteLine($"Student {name} doesn't exist.");
            }

            foreach (var studentMark in studentsMarks)
                Console.WriteLine($"Student {studentMark.Key}, mark = {studentMark.Value}");
        }

        static void SortedDict()
        {
            string text = "a text some text just some text";
            IDictionary<string, int> wordsCount = new SortedDictionary<string, int>();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            foreach (var w in wordsCount)
                Console.WriteLine($"Word {w.Key}, count = {w.Value}");
        }

        static void MenuList() // Task 1
        {
            List<int> list = new List<int>();
            while (true)
            {
                Console.WriteLine("1. Add item\n2. Remove item");
                Console.WriteLine("3. List all items\n4. Exit");

                string choice = Console.ReadLine();
                if (choice == "4")
                    break;
                switch (choice)
                {
                    case "1":
                        AddItem(list);
                        break;
                    case "2":
                        RemoveItem(list);
                        break;
                    case "3":
                        DisplayItems(list);
                        break;
                }
            }
        }
        static void AddItem(List<int> list)
        {
            Console.Write("New item > ");
            int item = int.Parse(Console.ReadLine());
            list.Add(item);
        }
        static void RemoveItem(List<int> list)
        {
            Console.Write("Item to delete > ");
            int item = int.Parse(Console.ReadLine());
            list.Remove(item);
        }
        static void DisplayItems(List<int> list)
        {
            Console.Write("Item:");
            foreach (var item in list)
                Console.Write($" {item}");
            Console.WriteLine();
        }

        static void Occurences() // Task 2
        {
            IDictionary<int, int> dict = new SortedDictionary<int, int>();
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            foreach(int x in array)
            {
                int count = 1;
                if (dict.ContainsKey(x))
                    count = dict[x] + 1;
                dict[x] = count;
            }

            foreach (var x in dict)
                Console.WriteLine($"{x.Key} --> {x.Value} times");

        }

        static void Removing() // Task 3
        {
            int[] numbers = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            IDictionary<int, int> dict = new SortedDictionary<int, int>();
            foreach (int x in numbers)
            {
                int count = 1;
                if (dict.ContainsKey(x))
                    count = dict[x] + 1;
                dict[x] = count;
            }

            List<int> list = new List<int>();
            foreach (var number in numbers)
                if (numbers[number] % 2 != 0)
                    list.Add(number);

            DisplayItems(list);
        }


        static void Minesweeper() // Homework 1
        {
            Console.WriteLine("Welcome to the minesweeper game!\n--------------------------------");
            // initialization
            int size;
            while (true)
            {
                Console.Write("Please choose the size of the battlefield > ");
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    size = x;
                    break;
                }
                else
                    Console.WriteLine("It's not a size, please enter an integer!");
            }
            // construction of the battlefield
            bool[,] battlefield = GeneratingMatrix(size);
            // displaying
            DisplayingMatrix(battlefield);
            // coordinates entering by user
            int indexRow = -1; int indexCol = -1;
            while (true)
            {
                bool checkRow = false; bool checkColumn = false;
                // row
                Console.WriteLine("Please choose coordinates (tap 'e' any times to exit)");
                do
                {
                    Console.Write("Enter an index of row > ");
                    string b = Console.ReadLine();
                    if (int.TryParse(b, out int x) && int.Parse(b) < battlefield.GetLength(0))
                    {
                        indexRow = x;
                        checkRow = true;
                    }
                    else if (b == "e")
                        goto breakOut;
                    else
                        Console.WriteLine("Error! It's not an index or the one you enter is greater than the size of the battlefield.");
                } while (checkRow == false);
                // column
                do
                {
                    Console.Write("Enter an index of column > ");
                    string a = Console.ReadLine();
                    if (int.TryParse(a, out int y) && int.Parse(a) < battlefield.GetLength(1))
                    {
                        indexCol = y;
                        checkColumn = true;
                    }
                    else if (a == "e")
                        goto breakOut;
                    else
                        Console.WriteLine("Error! It's not an index or the one you enter is greater than the size of the battlefield.");
                } while (checkColumn == false);

                if (battlefield[indexRow, indexCol] == true)
                    Console.WriteLine("BOOM!");
                else
                    Console.WriteLine("YEAH!");
            }
            breakOut:
            Console.WriteLine("End of the game!");
        }
        static bool[,] GeneratingMatrix(int size)
        {
            bool[,] matrix = new bool[size, size];
            Random r = new Random();
            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    int x = r.Next(0, 2); // x can be 0 or 1
                    if (x == 0)
                        matrix[i, j] = false;
                    else // means that x = 1
                        matrix[i, j] = true;
                }
            }
            return matrix;
        }
        static void DisplayingMatrix(bool[,] matrix)
        {
            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == false)
                        Console.Write(" O ");
                    else
                        Console.Write(" X ");
                }
                Console.WriteLine();
            }
        }

        static void Phonebook() // Homework 2
        {
            // Initialization
            Console.WriteLine("Phonebook:\n-----------");
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            int choice;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Please choose an operation (tap 'e' to exit):");
                    Console.WriteLine("\t 1. Insert a contact \n\t 2. Delete a contact \n\t " +
                        "3. Search a contact \n\t 4. List of all contacts");
                    string choiceString = Console.ReadLine();
                    if (int.TryParse(choiceString, out int x) && int.Parse(choiceString) < 5 && int.Parse(choiceString) > 0)
                    {
                        choice = x;
                        break;
                    }
                    else if (choiceString == "e")
                        goto breakOut;
                    else
                        Console.WriteLine("Error! This operation doesn't exist. Enter 1, 2, 3 or 4.");
                }

                // Call the right function
                switch (choice)
                {
                    case 1:
                        Insert(phonebook);
                        break;

                    case 2:
                        Delete(phonebook);
                        break;

                    case 3:
                        Search(phonebook);
                        break;

                    case 4:
                        List(phonebook);
                        break;
                }
            }
            breakOut:
            Console.WriteLine("End of the phonebook.");
        }
        static Dictionary<string, string> Insert(Dictionary<string, string> dico)
        {
            Console.WriteLine("Please insert the new contact:");
            string name, number;
            Console.Write("Enter a name > ");
            name = Console.ReadLine();
            while (true)
            {
                Console.Write("Enter the phone number > ");
                number = Console.ReadLine();
                if (number.Length == 10 && int.TryParse(number, out int x))
                {
                    dico.Add(name, number);
                    break;
                }
                else
                    Console.WriteLine("Error! Invalid format.");
            }


            Console.WriteLine("Do you want to enter another contact? (yes or no)");
            if (Console.ReadLine() == "yes")
                return Insert(dico);
            else
                return dico;
        }
        static Dictionary<string, string> Delete(Dictionary<string, string> dico)
        {
            Console.WriteLine("Please choose a contact to delete:");
            Console.Write("Enter a name > ");
            string name = Console.ReadLine();
            if (dico.ContainsKey(name))
                dico.Remove(name);
            else
                Console.WriteLine("Contact not found.");


            Console.WriteLine("Do you want to delete another contact? (yes or no)");
            if (Console.ReadLine() == "yes")
                return Delete(dico);
            else
                return dico;
        }
        static Dictionary<string, string> Search(Dictionary<string, string> dico)
        {
            Console.WriteLine("Please choose a contact to search:");
            Console.Write("Enter a name > ");
            string name = Console.ReadLine();
            if (dico.ContainsKey(name))
                Console.WriteLine($"{name}: {dico[name]}");
            else
                Console.WriteLine("Contact not found.");


            Console.WriteLine("Do you want to search another contact? (yes or no)");
            if (Console.ReadLine() == "yes")
                return Search(dico);
            else
                return dico;
        }
        static void List(Dictionary<string, string> dico)
        {
            foreach(var contact in dico)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }
    }
}
