using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt___2021
{
    class Quest3
    {
        
        public static void TheSign()
        {
            int answer1;
            bool answer = true; 
            while (answer)
            {
                Console.Clear();
                Pictures.Sign();
                Pictures.Doors();
                Console.WriteLine("You can feel heat coming from door number " + Quest2.failed + " there could be a fire");
                Console.WriteLine("You can feel cold coming from all the other doors");
                Console.WriteLine("Which door do you choose?");
                Console.WriteLine("Your answer: ");
                answer1 = int.Parse(Console.ReadLine());

                if (answer1 == Quest2.failed)
                {
                    Dialog.CorrectDoor();
                    string back;
                    back = Console.ReadLine();

                    if (back == "enter" || back == "Enter")
                        answer = false;
                }
                if (answer1 != Quest2.failed)
                {
                    Console.WriteLine("The room is emty");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        public static void Numbers()
        {
            
            int number1;
            int number2;
            int number3;
            int number4;
            bool Try = false;

            while (Try == false)
            {
                Console.Clear();
                Pictures.Notes();
                Console.Write("First digit: ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("Second digit: ");
                number2 = int.Parse(Console.ReadLine());
                Console.Write("Third digit: ");
                number3 = int.Parse(Console.ReadLine());
                Console.Write("Last digit: ");
                number4 = int.Parse(Console.ReadLine());

                if (number1 == 3 && number2 == 4 && number3 == Quest2.failed && number4 == 1)
                {
                    Console.Beep(3000, 1000);
                    Try = true;
                }
                else
                    Console.Beep(250, 2000);
            }
        }
    }
}
