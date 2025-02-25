using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofDes.Practice
{ 
    class CSAdvancedSyntax
    {
        static void Main(string[] args)
        {
            //Arrays
            /* Create an array of 3 integers and calculate their sum*/

            int[] array = new int[3];
            array[0] = 4;
            array[1] = 3;
            array[2] = 3;

            int sum = array[0] + array[1] + array[2];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\nsum = {sum}\n");

            //Strings
            /* Check if a string contains a specific word.*/
            string word = "I'm a baby girl in a Barbie world";
            Console.WriteLine(value: word.Contains("barbie", StringComparison.CurrentCultureIgnoreCase)+"\n");

            //For Each Loop
            /*Print an array of numbers {2,4,6,8} using foreach loop*/

            int[] array2 = new int[] { 2, 4, 6, 8 };
            foreach (int num in array2)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Navarra";
            car1.DisplayInfo();


        }
        //Classes and object
        /*Create a class Car with properties Make,
        Model, and a method DisplayInfo that prints
        car details.*/
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine($"{Make}, {Model}");
            }
        }
    }
}
