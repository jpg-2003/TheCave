using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt___2021
{
    class Quest2
    {
        
        public static void InvComputer()
        {
            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = true;
            bool login = true;
            while (login)
            {
                Console.Write("User: ");
                string brugernavn = Console.ReadLine();
                Console.Write("Password: ");
                string adgangskode = Console.ReadLine();

                if (brugernavn == "admin" && adgangskode == "1234")
                    login = false;
                else if (brugernavn == "Leave" && adgangskode == "Pc")
                {
                    Pictures.PC();
                    Console.WriteLine("Press 'Enter' to investigate the computer. . .");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
                else 
                { 
                    Console.Beep(500, 1000);
                    Console.WriteLine("Unknown user or password");
                    Console.WriteLine("Type in 'Leave' as user and 'Pc' as password to leave the computer");
                    System.Threading.Thread.Sleep(2500);
                }             
            }
            Console.Clear();
            Console.WriteLine("You did it");

            System.Threading.Thread.Sleep(1000);
            Console.Write("Hello ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("Who are you? ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Wait how did you get the log-in codes? ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.Write("It doesn't matter. ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("What do you want?");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.Write("That doesn't matter either. ");
            System.Threading.Thread.Sleep(1000);

            bool Friend = true;
            while (Friend)
            {
                Console.Clear();
                Console.WriteLine("Are you a Friend?");
                Console.Write("(Y/N): ");
                string result = Console.ReadLine();
            
                if (result == "n"||result == "n")
                {
                    Console.WriteLine("Why not?");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Come back when you are more reasonable");
                    System.Threading.Thread.Sleep(2000);

                }
                else if (result == "y" || result == "Y")
                {
                    Friend = false;
                }
                else
                {
                    Console.WriteLine("invalid answer!");
                    System.Threading.Thread.Sleep(1000);
                }
            }

            Console.Clear();
            Console.Write("Well");
            System.Threading.Thread.Sleep(1000);
            Console.Write(", Now that we all are friends");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Shouldn't we play a game?");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.Write("Yes we should");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.Write("I am");
            System.Threading.Thread.Sleep(1000);
            
            Console.Write(" going to give");
            System.Threading.Thread.Sleep(1000);
            
            Console.Write(" 3 riddles ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.Write("and if ");
            System.Threading.Thread.Sleep(1000);
            
            Console.Write("you don't answer correctly ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("i'll kill your friend!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.Write("Riddle number 1:");
        }
        
        public static int failed = 0;
        public static void Riddle1()
        {
            string answer1;
            bool answer = true; 
            int incorrect = 1;
            Console.Clear();
            Console.WriteLine("You get 3 attempts");
            Console.WriteLine("You will be shown a list of numbers and you need to type in the first number");
            for (int i = 0; i <= 12; i++)
                Console.WriteLine(i);
           
            while (answer)
            {
                Console.WriteLine("Your answer: ");
                answer1 = Console.ReadLine();

                if (answer1 == "the first number")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct");
                    System.Threading.Thread.Sleep(3000);
                    answer = false;
                }
                else if (incorrect == 3)
                {
                    Console.Clear();
                    Console.WriteLine("no more attempts");
                    System.Threading.Thread.Sleep(3000);
                    answer = false;
                    failed++;
                }
                else
                {
                    Console.WriteLine("That is wrong try again");
                    System.Threading.Thread.Sleep(1000);
                    incorrect++;
                }

            }
        }

        public static void Riddle2()
        {
            Console.Write("Riddle number 2:");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            string answer1;
            bool answer = true;
            int incorrect = 1;
            Console.WriteLine("How many sides does a circle have?");

            while (answer)
            {
                Console.WriteLine("Your answer: ");
                answer1 = Console.ReadLine();

                if (answer1 == "two" || answer1 == "2" || answer1 == "Two")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. It has an inside and an outside!");
                    System.Threading.Thread.Sleep(3000);
                    answer = false;
                }
                else if (incorrect == 3)
                {
                    Console.Clear();
                    Console.WriteLine("no more attempts");
                    System.Threading.Thread.Sleep(3000);
                    answer = false;
                    failed++;
                }
                else
                {
                    Console.WriteLine("That is wrong try again");
                    System.Threading.Thread.Sleep(1000);
                    incorrect++;
                }
            }
        }
        
        public static void Riddle3()
        {
            Console.Write("Riddle number 3:");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            string answer1;
            bool answer = true;
            int incorrect = 1;
            Console.WriteLine("What can fill a room but takes up no space?");

            while (answer)
            {
                Console.WriteLine("Your answer: ");
                answer1 = Console.ReadLine();

                if (answer1 == "light" || answer1 == "Light")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct");
                    System.Threading.Thread.Sleep(3000);
                    answer = false;
                }
                else if (incorrect == 3)
                {
                    Console.Clear();
                    Console.WriteLine("no more attempts");
                    System.Threading.Thread.Sleep(3000);
                    answer = false;
                    failed++;
                }
                else
                {
                    Console.WriteLine("That is wrong try again");
                    System.Threading.Thread.Sleep(1000);
                    incorrect++;
                    
                }
            }
        }
        public static bool Dead = false;
        
        public static void IsHeDead()
        {
            Console.Clear();
            Console.Write("Well you got ");
            System.Threading.Thread.Sleep(1000);
            Console.Write(failed);
            System.Threading.Thread.Sleep(1000);
            Console.Write(" of the riddles wrong");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            if (failed == 0)
            {
                Console.Write("Damn it, ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("that means you ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("get to keep you friend");
                System.Threading.Thread.Sleep(1000);
                Dead = false;
            }
            else if (failed > 0)
            {
                Console.Write("You know what that means ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("Your little friend is ");
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("DOOMED!");
                Console.ResetColor();
                System.Threading.Thread.Sleep(1000);
                Dead = true;
            }
        }
    }
}
