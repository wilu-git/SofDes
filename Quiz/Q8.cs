using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofDes.Quiz
{
    class Student
    {
        public string name{ get; set; }
        public double age { get; set; }
        public double[] grade { get; set; }
        public double averageGrade { get; set; }
    }
    class Q8
    {
        public static void Main(string[] args)
        {
            int numStudent = 0; //initialize number of students set to 0
            while (true)
            {
                Console.WriteLine("Please input how many students to put in");
                string inputnum = Console.ReadLine();
                if (int.TryParse(inputnum, out numStudent)) break;

                else
                {
                    Console.WriteLine("Invalid Input please put a number");
                }

                }

            // initialize a listset/hashmap that will store the information of the students
            List<Student> students = new List<Student>(); 
            
            //initialize the for loop statement to request for input
            for (int i = 0; i < numStudent; i++)
            {
                Student student = new Student();
                Console.WriteLine($"\nStudent {i+1}: "); //indexing of students

                Console.Write("Name: ");
                student.name = Console.ReadLine();

                while (true)
                {
                    Console.Write("Age: ");
                    String inputAge = Console.ReadLine();
                    if (double.TryParse(inputAge, out double age)) // check if input is a nubmer
                    {
                        student.age = age;
                        break;
                    }
                    else Console.WriteLine("invalid Input please put age");
                }

                student.grade = new double[3]; //initialize the array in order to input the grades
                for (int j = 0; j < 3; j++)
                {
                    while (true)
                    {
                        Console.Write($"Grade {j + 1}: ");
                        String inputGrade = Console.ReadLine();
                        if (double.TryParse(inputGrade, out double grade)) //check if the input is a number
                        {
                            student.grade[j] = grade;
                            break;
                        }
                        else Console.WriteLine("invalid input please put grade");

                    }
                    double sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        sum += student.grade[k];

                    }
                    student.averageGrade = sum / 3;
                } 
                students.Add(student); //adding the student inputted in the hashmap
            }


            //display the student information
            for (int l = 0; l < numStudent; l++)
            {
                Console.WriteLine($"\nStudent {l+1}:\nName: {students[l].name} \nAge: {students[l].age} \nAverage Grade: {students[l].averageGrade}");
            }

        }
    }
}
/*
 * Maria is developing a simple Student Management System using C#. She needs to create a class named Student that stores a student's name, age, and grades (stored in an array). The program should:

- Ask the user how many students they want to input.
- For each student, ask for their name, age, and 3 grades.
- Calculate and display the average grade for each student.
- Display all student details in a structured format.*/
