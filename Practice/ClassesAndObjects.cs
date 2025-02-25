using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SofDes.Practice
{
    class BankAccount
    {
        private double balance { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            { balance -= amount; }
            else
            { Console.WriteLine("Invalid amount"); }
        }
        public double GetBalance()
        {
            return balance;
        }

    }

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }

    class Student : Person
    {
        public string studentId { get; set;}

        override public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, StudentID: {studentId}");
        }

    }
    class ClassesAndObjects
    {
        //encapsulation
        /*Create a class BankAccount with a
        private field balance. The balance should
        be modified using Deposit() and
        Withdraw() methods. Provide a method to
        get the current balance.*/

        

        static void encapsulation()
        {
            BankAccount acc1 = new BankAccount();
            while (true)
            {
                Console.WriteLine("please input the deposit amount: ");
                String amountInput = Console.ReadLine();
            if (double.TryParse(amountInput, out double amount))
                { 
                    acc1.Deposit(amount); 
                    break; 
                }
                else { Console.WriteLine("Invalid input!"); }
            }
            Console.WriteLine("Current balance: "+acc1.GetBalance());

            while (true)
            {
                Console.WriteLine("please input the withdraw amount: ");
                String amountInput = Console.ReadLine();
                if (double.TryParse(amountInput, out double amount))
                {
                    acc1.Withdraw(amount);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }Console.WriteLine("Current Balance:"+acc1.GetBalance());

        }

        //Inheritance
        /*Create a base class Person with properties
        Name and Age, and a method DisplayInfo().
        Then, create a derived class Student that
        inherits from Person and adds a StudentID
        property.In Main(), create an object of Student
        and display its details.*/

        public static void inheritance()
        {
            Student student1 = new Student();
            student1.name = "Louie";
            student1.age = 21;
            student1.studentId = "20-0023-924";

            student1.DisplayInfo();

        }

        //Polymorphism 
        /*Create a base class Animal with a method
        MakeSound(). Then, create two
        subclasses Dog and Cat that override
        MakeSound() with different sounds.*/

        class Animal
        {
            public virtual string MakeSound() {return("lol");}
        }
        class Dog : Animal
        {
            public override string MakeSound()
            {
                return("I woof");
            }
        }
        class Cat : Animal
        {
            public override string MakeSound()
            {
                return("I meow");
            }
        }
        static void polymorphism()
        {
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();

            Console.WriteLine("Dog = "+dog1.MakeSound());
            Console.WriteLine("Cat = " + cat1.MakeSound());
        }


        //Abstraction 
        /*Create an abstract class Shape with an
        abstract method CalculateArea(). Then, create
        two derived classes, Circle and Rectangle, that
        implement the method with their own logic.*/

        abstract class Shape
        {
            public abstract void CalculateArea();
        }

        class Circle : Shape
        {
            public double radius { get; set; }
            public override void CalculateArea(){
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"Circle Area = {area}");
            }
        }
        class Rectangle : Shape
        {
            public double length;
            public double width;
            public override void CalculateArea()
            {
                double area = length * width;
                Console.WriteLine($"Rectangle Area = {area}");
            }
        }

        public static void abstraction()
        {
            Rectangle rec = new Rectangle { length = 5, width = 10 };

            rec.CalculateArea();

            Circle circ = new Circle{radius = 3};

            circ.CalculateArea();
        }

        public static void Main(string[] args)
        {
            //encapsulation();
            //inheritance();
            //polymorphism();
            //abstraction();

        }
    }
}
