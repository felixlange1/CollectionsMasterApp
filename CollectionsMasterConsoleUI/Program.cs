using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array
            Console.WriteLine(numbers[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            
            Array.Reverse(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var integerList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(integerList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(integerList);

            //TODO: Print the new capacity
            Console.WriteLine(integerList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userNumber = int.Parse(Console.ReadLine());
            NumberChecker(integerList, userNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(integerList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(integerList);
            NumberPrinter(integerList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            integerList.Sort();
            NumberPrinter(integerList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var integerArray = integerList.ToArray();

            //TODO: Clear the list
            integerList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> integerList)
        {
            for (int i = integerList.Count - 1; i >= 0; i--)
            {
                if (integerList[i] % 2 != 0)
                {
                    integerList.Remove(integerList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> integerList, int userNumber)
        {
            bool found = false;
            foreach (int number in integerList)

            {
                if (number == userNumber)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"Yes, {userNumber} is found in the list.");
            }
                    
            else
            {
                Console.WriteLine("Sorry, that number is not in the list.");
            }
        }

        // {
        // bool found = false;
        // for (int i = 0; i < integerList.Count; i++)
        // {
        //     if (integerList[i] == userNumber)
        //     {
        //         found = true;
        //     }
        // }
        //
        // if (found)
        // {
        //     Console.WriteLine($"Yes, {userNumber} is found in the list.");
        // }
        //          
        // else
        // {
        //     Console.WriteLine("Sorry, that number is not in the list.");
        // }
        
        
        private static void Populater(List<int> integerList)
        {
            for (int i = 1; i <= 50; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 50);
                integerList.Add(randomNumber);
            }
        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                int randomNumber = rng.Next(0, 50);
                numbers[i] = randomNumber;
            }
        }        

        private static void ReverseArray(int[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
