using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt___2021
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool gameOn = true;

            while (gameOn)
            {
                Pictures.ThePage();
                Dialog.WakeUp();
                Program1.StartHardcore();
                Dialog.TheComputer();
                Quest2.InvComputer();
                Quest2.Riddle1();
                Quest2.Riddle2();
                Quest2.Riddle3();
                Quest2.IsHeDead();
                Dialog.Affraid();
                Dialog.WhatsNowThis();
                Dialog.ThatsStrange();
                Quest3.TheSign();
                Dialog.Codes();
                Quest3.Numbers();
                Dialog.TheEnd();

                string again;
                again = Console.ReadLine();
                if (again == "Exit" || again == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Bye for now");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }   
            }
        }
    }
}
