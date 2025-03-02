using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofDes.Quiz
{
    class Number2
    {
        static List<S> registeredStudents = new List<S>();
        

        public static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Welcome to Emma's Student Registration System\nPlease input what you want to do:\n" +
                    "\n1 - Register Student" +
                    "\n2 - Edit Student Info" +
                    "\n3 - Display Student Info" +
                    "\n4 - Exit");
                

                string inNumChoice = Console.ReadLine();
                if (int.TryParse(inNumChoice, out int numChoice))
                    switch (numChoice)
                    {
                        case 1:
                            registerStudent();
                            break;
                        case 2:
                            editStudent(registeredStudents);
                            break;
                        case 3:
                            displayStudent();
                            break;  
                        case 4:
                            Console.WriteLine("Thank you for using the program!");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Choice out of range");
                            break;
                    }
                else
                {
                    Console.WriteLine("Invalid Input please put a number");
                }
            }

        }
        public static void editStudent(List<S> regstudents)//import the list of the students
        {
            
            if (regstudents.Count == 0) //check if the student list is empty 
            {
                Console.WriteLine("No student registered yet");
                return; 
            }            

            else if (true) { //if student list is not empty then proceed to request for input to find the student
                bool studentFound = false;
                Console.WriteLine("Please input the UID of the student you want to edit: ");
                String UIDcheck = Console.ReadLine();
                foreach (var student in regstudents)
                {
                    if (student.UID == UIDcheck)
                    {
                        studentFound = true;
                        Console.WriteLine("Student found. Please input the new name: ");
                        student.Name = Console.ReadLine();
                        Console.WriteLine($"Student Name updated to{student.Name}.");
                        break;
                    }
                }

                if (!studentFound)
                {
                    Console.WriteLine("Student with the given UID not found.");
                }
            }
              

        }

        public static void displayStudent() //display the list of student by using for loop
        {
            int numStudent = registeredStudents.Count;
            
            if (numStudent == 0)
            {
                Console.WriteLine("\nNo student registered yet\n");
                return;
            }else
                for (int i = 0; i < numStudent; i++)
                {
                    Console.WriteLine("Here are the list of the student: ");
                    Console.WriteLine($"Student[{i}]: \nName:{registeredStudents[i].Name}, Department:{registeredStudents[i].Department}, Phone #:{registeredStudents[i].PhoneNum}");

                }

        }


            

        public static int registerStudent()
        {

            //initialize number of students set to 0
            int numStudent = 0;
            do
            {
                Console.WriteLine("input number of student to register: ");
                string inputNum = Console.ReadLine();
                {
                    if (int.TryParse(inputNum, out numStudent)) break;
                    Console.WriteLine("Invalid input please put a number");
                }
            }
            while (true);

            for (int i = 0; i < numStudent; i++)
            {
                S s = new S();
                Console.WriteLine($"\nStudent {i + 1}: "); //indexing of students

                Console.Write("Name: "); //get name
                s.Name = Console.ReadLine();

                Console.Write("Department: "); //get department
                s.Department = Console.ReadLine();


                do
                {
                    Console.Write("Phone# (Follow this format 09*********): ");
                    string PhoneNum = Console.ReadLine();
                    {
                        if (isPhoneNum(PhoneNum))
                        {
                            s.PhoneNum = PhoneNum; break;
                        }
                        else Console.WriteLine("Invalid Input please put proper phone number");
                    }

                } while (true);

                s.UID = generateUID(s.Department, s.PhoneNum);

                while (true)
                {
                    Console.WriteLine($"your generated UID is:{s.UID}\nWould you like to change your designated UID?(y/n): ");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        Console.WriteLine($"Your generated UID is: {s.UID}\nPlease input your desired UID: ");
                        s.UID = Console.ReadLine();
                        break;
                    }
                    else if (choice == "n")
                    {
                        Console.WriteLine($"Your generated UID is: {s.UID}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                }
                registeredStudents.Add(s);
            } return numStudent;
        }

        public static string generateUID(string Dep, string nP)
        {
            return ("" + Dep[0] + Dep[1] + Dep[2] + nP[8] + nP[9] + nP[10] +  "");
        }
        public static bool isPhoneNum(string phoneNum)
        {
            return phoneNum[0] == '0' && phoneNum[1] == '9' && phoneNum.Length == 11 && isDigit(phoneNum);
        }

        public static bool isDigit(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
        
    }
    class S
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string PhoneNum { get; set; }
        public string UID { get; set; }
    }
}
/*Emma is developing a Student Registration System using C#. She needs to create a class named Student that stores a student’s full name, department, and formatted student ID.

The program should:

- Ask the user how many students they want to register.
- For each student, ask for their full name, department, and generate a Student ID using the first three letters of their department + last four digits of their contact number.
- Allow users to edit a student's name (replace any part of their name).
- Display the updated student details in a structured format.*/
