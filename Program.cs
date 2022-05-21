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
            string text = "Giraffe \n \" Academy" + " is cool";
            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Contains("Academy"));
            Console.WriteLine(text.Contains("Academies"));
            Console.WriteLine(text[0]);
            Console.WriteLine(text[2]);
            Console.WriteLine(text.IndexOf("Academy"));
            Console.WriteLine(text.IndexOf("f"));
            Console.WriteLine(text.IndexOf("z"));
            Console.WriteLine(text.Substring(12, 3));
            Console.WriteLine(text.Substring(text.IndexOf("Academy")));
            Console.WriteLine("");

            //Numbers
            Console.WriteLine(40);
            Console.WriteLine(-5.783);
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 % 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);

            int num = 6;
            num++;
            num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.6));

            //Console.ReadLine();
        }
    }
}
