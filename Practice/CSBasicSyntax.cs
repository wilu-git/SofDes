using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace SofDes.Practice
{
    class CSBasicSyntax

    {
        static void Main(string[] args)
        { 
//        
// /*           Write a C# program that declares an integer variable age
//             * with a value of 25 and a string variable name with the value "Alex"
//             * print them using a single Console.WriteLine() statement*/


//            int age = 25;
//            string name = "Alex";
//            //"$" in order to show the variable 
//            Console.WriteLine($"name: {name} age: {age}");

///*            Write a C# program that asks the user for their
//            name and age, and then prints a message like
//            "Hello Alex, you are 25 years old!".*/

//            Console.WriteLine("Please input your Name: ");
//            name = Console.ReadLine();

//            Console.WriteLine("Please input your Age: ");
//            string ageInput = Console.ReadLine();
//            if (int.TryParse(ageInput, out age))
//            {
//                Console.WriteLine($"Hi {name}! you are {age} years old!\n");
//            }
//            else 
//            {
//                Console.WriteLine("Invalid input for age\n");
//            }

            

///*            Write a C# program that takes a number (1–3)
//            as input and prints the corresponding day of
//            the week(1 = Monday, 2 = Tuesday, 3 =
//            Wednesday). If the number is not between 1
//            and 3, print "Invalid input.".Use switch
//            statements only.
//*/
//            Console.WriteLine("Please input number 1 - 3");
//            int choice = int.Parse(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                default:
//                    Console.WriteLine("Invalid Input");
//                    break;
//            }Console.WriteLine();

//            /*Write a C# program that asks the user
//            to input 5 numbers and calculates
//            their total sum using a for loop.*/

            int sum = 0;
            int limit;

            while (true)
            {
                Console.WriteLine("Please input how many numbers you want to add: ");
                string limitInput = Console.ReadLine();
            
                if (int.TryParse(limitInput, out limit)) {break;}

                else
                {
                    Console.WriteLine("invalid number input");
                }

            }
            
            for (int i = 0; i != limit; i++)
            {
                Console.Write($"Num {i+1}: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine("Invalid input: ");
                    i--;
                }
                

            }
            Console.WriteLine($"Total sum = {sum}");

        }

    }
}
