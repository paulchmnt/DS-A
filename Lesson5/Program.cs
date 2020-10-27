using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static void MinMaxElements()
        {
            /* Find Min and Max elements in the array
            Step 1: Start
            Step 2: Define variables max & min
            Step 3: Read array
            Step 4: min = max = array[0]
            Step 5: For each element in array
                        if(element<min)
                            min = element
                        if(element>max)
                            max = element
            Step 6: Display min, max
            Step 7: End
            */
        }

        static void Average()
        {
            /* Calculate average value of the array items
            Step 1: Start
            Step 2: Define variable average, sum, count
            Step 3: Read the array
            Step 4: For each element of the array
                        sum += element
                        count ++
            Step 5: average = sum/count
            Step 6: Display average
            Step 7: End
            */
        }

        static void SwapItem()
        {
            /* Swap 2 arrays items
            Step 1: Start
            Step 2: Define variable temp
            Step 3: Read the array
            Step 4: Read index1 & index2
            Step 5: Check if the indexes exist in the array
            Step 6: temp = array[index1]
            Step 7: array[index1] = array[index2]
            Step 8: array[index2] = temp
            Step 9: End
            */
        }

        static void AddStack() // Teacher version on github, he used an array for the Stack data structure
        {
            /* Add element into Stack data structure
            Step 1: Start
            Step 2: Define variable element, a new object Stack
            Step 3: Read element from the user
            Step 4: Add element in the stack (stack.Push(element))
            Step 5: Restart from step 3 until you don't want to add another element
            Step 6: End
            */
        }

        static void RemoveStack() // Teacher version on github, he used an array for the Stack data structure
        {
            /* Remove element from Stack data structure
            Step 1: Start
            Step 2: Read the stack
            Step 3: Remove element from the top of the stack (stack.Pop())
            Step 4: Restart from step 3 until you don't want to remove another element
            Step 5: End
            */
        }

        static void AddTree()
        {
            /* Add element into Binary tree
            Step 1: Start
            Step 2: Declare binary tree, element
            Step 3: Read element from the user and store it in
            Step 4: Add element in the tree
            Step 5: Read a new element from the user and store it in
            Step 6: if (new element < previous element)
                        store new element at the left of previous element (new subtree)
                    else
                        store it at the right
            Step 7: Restart from step 5 until you don't want to add a new element
            Step 8: End            
            */
        }

        static void SwapArrays()
        {
            /* Swap all elements of 2 arrays
            Step 1: Start
            Step 2: Define variable temp
            Step 3: Read the 2 arrays
            Step 4: Check if both of the arrays have the same size
            Step 5: For i = 0 to array.Length - 1 with incrementation of 1
                        temp = array1[i]
                        array1[i] = array2[i]
                        array2[i] = temp
            Step 6: End
            */
        }

        static void Smallest()
        {
            /* Put smallest element as 1st item in the array
            Step 1: Start
            Step 2: Define variables min, index, temp
            Step 3: Read the array
            Step 4: min = temp = array[0], index = 0
            Step 5: for i = 0 to array.Length - 1 with incrementation of 1
                        if (array[i] < min)
                            min = array[i]
                            index = i
            Step 6: array[0] = array[index]
            Step 7: array[index] = temp
            Step 8: End
            */

        }
    }
}
