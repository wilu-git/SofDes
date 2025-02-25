using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SofDes.Discussion
{
    class CSBasicSyntaxDisc
    {
        static void Main(string[] args)
        {
            //Printing statements & variables
            Console.WriteLine("Hi I'm printing statements");

            //Input statements
            Console.WriteLine("Please input word: ");
            string input = Console.ReadLine();
            Console.WriteLine("Please input number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"num: {number} \nword: {input}");

            //switch statement
            Console.WriteLine("Please input number 1 - 3");
            int expression = int.Parse(Console.ReadLine());

            switch (expression)
            {
                case 1://value1:
                    // Code to execute if expression == value1
                    Console.WriteLine("You pressed 1");
                    break;
                case 2: //value2:
                    // Code to execute if expression == value2
                    Console.WriteLine("You pressed 2");
                    break;
                case 3: //value3:
                    // Code to execute if expression == value3
                    Console.WriteLine("You pressed 3");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    // Code to execute if no case matches
                    break;
            }

            for (int i = 0/*initialization*/;
                i < 3/*condition*/;
                i++/*increment / decrement*/)
            {
                // Body of the loop
                Console.Write($"Ha{i+1} ");    
            }
            Console.WriteLine();


            while (true/*condition*/)
            {
                Console.WriteLine("The Code is Running");

                Console.WriteLine("The Code is Stopping break;");
                break;

                // Body of the loop
            }

            bool running = false;
            do
            {
                //Print hotdog
                Console.WriteLine("hotdog");
                //Body of the loop
            }
            while (running /*condition*/);





        }
    }
}