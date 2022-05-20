using System;

namespace CS_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Intro();
            
        }
        public void Intro()
        {
            //Hello World!
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            //Making a shape with Console.WriteLine
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.WriteLine("");

            //Variables
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + "years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name" + characterName);
            Console.WriteLine("But he didn't like being " + characterAge);
            Console.WriteLine("");

            //Data Types
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;
            Console.WriteLine("");

            //Strings
            string text = "Giraffe \n \" Academy" + "is cool";
            Console.WriteLine(text.Length);

            //Console.ReadLine();
        }
    }
}
