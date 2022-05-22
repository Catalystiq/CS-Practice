using System;

namespace CS_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Intro();
            //program.Input();
            //program.BasicCalculator();
            //program.MadLib();
            //program.Arrays();
            //SayHi("Mike", 33);
            //SayHi("John", 56);
            //SayHi("Tom", 12);
            //int cubedNumber = Cube(5);
            //Console.WriteLine(cubedNumber);
            //program.If();
            //Console.WriteLine(GetMax(20, 10, 40));
            //program.BetterCalculator();
            //Console.WriteLine(GetDay(4));
            //program.While();
            //program.Guess();
            //program.For();
            //Console.WriteLine(GetPow(3, 2));
            //program.AdvancedArrays();
            //program.Comments();
            //program.Exceptions();
            //program.ClassesAndObjects();
            //program.ObjectMethods();
            //program.GetSet();
            //program.StaticAttributes();
            //program.StaticMethods();
            //program.Inheritance();

            Console.ReadLine();
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
        }

        public void Input()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        public void BasicCalculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }

        public void MadLib()
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);
        }

        public void Arrays()
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        public void If()
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        public void BetterCalculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        public void While()
        {
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }

        public void Guess()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
        }

        public void For()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public void AdvancedArrays()
        {
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1, 1]);
        }

        public void Comments()
        {
            // This prints something out
            /*
             * asdf
             * fdas
             * fdsa
             * sadf
            */
            Console.WriteLine("Comments are fun"); //Comments
        }

        public void Exceptions()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }
            
        }

        public void ClassesAndObjects()
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            Console.WriteLine(book2.author);
        }

        public void ObjectMethods()
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }

        public void GetSet()
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);
        }

        public void StaticAttributes()
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
            
            Console.WriteLine(kashmir.title);
        }

        public void StaticMethods()
        {
            UsefulTools.SayHi("Mike");
        }

        public void Inheritance()
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
