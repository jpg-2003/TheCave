using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt___2021
{
    class Dialog
    {
        public static void Space()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void WakeUp()
        {
            Space();
            Console.CursorVisible = false;
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You: Wait, where am i? Why cant I see anything?                                                                    ");
            Console.WriteLine("HELLO, IS ANYONE THERE!?                                                                                          ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Stranger: SHHHH!!! They are going to hear you. Be quiet.                                                          ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You: Who are they? And who are you??                                                 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Stranger: Don't you remenber me? It dosn't matter, we gotta get out. Im cuffed so I can't help you, here take my map,");
            Console.WriteLine("it shows the way out but it's a bit confussing. you got to get to the trapdoor, but there is only one correct trapdoors");
            Console.WriteLine("but they are all markedet with a '?' and the route you take are markedet as you walk. And don't hit walls!                                                                                                                  ");
            Console.ResetColor();
            Console.Write("                                                                                              Press 'enter' to continue. . .");

            Console.ReadLine();
            Console.Clear();
        }
        public static void Blind()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Space();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You: Damn it's bright down here, my eyes gotta adjust first.");
            Console.WriteLine("It took a while to find this trapdoor, but why is it so bright down here?");
            Console.WriteLine("I can't see anything, wait hold on now i start to see");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                                                                                              Press 'enter' to continue. . .");
            Console.ReadLine();
        }
        public static void TheComputer()
        {
            Pictures.PC();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You: What is now this? I thought he said this was the way out. What kind of computer is this? It looks like some sort of AI.");
            Console.WriteLine("Let's make it quick.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                                                                                 Press 'enter' to investigate the computer. . .");
            Console.ReadLine();
        }
        public static void Affraid()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Space();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Narrator: You storm out the white room, and follow the path back to where your supposed friend is. Affraid for his life ");
            Console.WriteLine("you run without caring of the supposed enemies there is.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                                                                                 Press 'enter' to continue. . .");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void WhatsNowThis()
        {
            Pictures.Cat();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You: Is that a cat? It has to be. Wait what is this? A key? But where is the lock? I have got to get out before i end up dead");
            Console.WriteLine("we could try the map again, it seemed to change.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Narrator: You follow the map to the hall way.");
            Console.ResetColor();
            Console.Write("                                                                               Press 'enter' to continue. . .");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void ThatsStrange()
        {
            Console.Clear();
            Space();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Narrator: On your way out you notice scratching in the wall. The marks looks like:");
            Console.WriteLine("      ^       ^            ");
            Console.WriteLine("   -> | -> <- |     You decide that this most be a path so you decide to take the route. Only to find a sign and 4 doors.");
            Console.WriteLine("the sign says 'REMEMBER YOUR FLAWS'");
            Console.ResetColor();
            Console.Write("                                                                                 Press 'enter' to continue. . .");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void CorrectDoor()
        {
            Console.Clear();
            Space();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You: It's getting warm. But I only see a keypad. I don't have the code, or do I?");
            Console.ResetColor();
            Console.Write("                                       type in 'Back' followed by Pressing 'enter' to go back or 'Enter' to give it a try. . .");
            
        }
        public static void Codes()
        {
            Console.Clear();
            Pictures.Notes();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________");
            Console.WriteLine("Dialog:                                                                                                           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Narrator: There isn't much to see here, except two notes and a keypad. Let's give it a try");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ResetColor();
            Console.Write("                                                                                 Press 'enter' to continue. . .");
            Console.ResetColor();
            Console.ReadLine();

        }
        public static void TheEnd()
        {
            Console.Clear();
            Pictures.EndScreen();
            Console.WriteLine("You made it!");
            Console.WriteLine("You are now safe and chilling on a beach waiting for a pick up");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Your stats:");
            if (Quest2.Dead == false)
                Console.WriteLine("You friend made it out alive, if the AI keeps it's word");
            else if (Quest2.Dead == true)
                Console.WriteLine("You friend didn't make it");
            Console.WriteLine("You got {0} failed riddles", Quest2.failed);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Type in 'Exit' to exit or anything else to play again. . .");
        }

    }
}
