using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday
{ //Monday 15/10/18
    class Program
    {
        //Revision TASK 1:
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Please enter the name {i}");
                names[i] = Console.ReadLine();
            }


        }

        //Revision TASK 2:
        public static void task2()
        {
            int[] nums = new int[10];
            Random rand = new Random();
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total = +nums[i];
            }

            Console.WriteLine($"Average of the ten number in the array is {total / nums.Length}");
        }

        //Arrays Extended Practise Exercises - Task 1:
        public static void extended()
        {
            int[] numbers = new int[50];
            Random rand = new Random();
            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = rand.Next(1, 100);

            }
            Array.Sort(numbers);

            //Task2:
            Array.IndexOf(numbers, 55);

            //Task3:
            int[] newArray = new int[50];
            Array.Copy(numbers, newArray, int[50]);

            //Task4:
            Array.Reverse(numbers);
            Console.WriteLine(numbers);
        }

    }
}

