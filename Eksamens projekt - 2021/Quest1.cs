using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt___2021
{

    class TitleScreen
    {
        public static bool displayMenu = true;
        public static void Mainmenu()
        {
            
            while (displayMenu)
            {
                displayMenu = Difficulty();
            }
        }
       
        public static bool Difficulty()
        {
                Program1.StartHardcore();
                return true;
        }
    }

    public class Position
    {
        public int left;
        public int top;
    }
    class Program1
    {
        //set-up
        private static List<Position> points = new List<Position>();
        public static bool Done = true;
        private static DateTime nextUpdate = DateTime.MinValue;
        private static Position shortCut;
        private static Position _Danger;
        private static Random _rnd = new Random();
        static ConsoleKeyInfo? _lastKey;

       

        public static void StartHardcore()
        { 
            Console.Clear();
            Console.CursorVisible = false;
            
            nextUpdate = DateTime.MinValue;
            
            
            DrawPoints();
            
            _lastKey = null;
           
            DrawScreen();
            while (Done == true)
            {
                if (AcceptInput() || UpdateHardcore())
                    DrawScreen();
            }
            
        }

        private static bool UpdateHardcore()
        {
            if (DateTime.Now < nextUpdate)
                return false;

            if (_lastKey.HasValue)
            {
                Move(_lastKey.Value);
            }

            nextUpdate = DateTime.Now.AddMilliseconds(100);
            return true;
        }

        private static void DrawPoints()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            shortCut = new Position()
            {
                left = _rnd.Next(Console.WindowWidth),
                top = _rnd.Next(Console.WindowHeight)
            };
            Console.SetCursorPosition(shortCut.left, shortCut.top);
            Console.Write('?');

            for (int i = 0; i <3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _Danger = new Position()
                {
                    left = _rnd.Next(Console.WindowWidth),
                    top = _rnd.Next(Console.WindowHeight)
                };
                Console.SetCursorPosition(_Danger.left, _Danger.top);
                Console.Write('?');
                Console.ResetColor();
            }
        }
        private static void DrawScreen()
        {
            foreach (var point in points)
            {
                Console.SetCursorPosition(point.left, point.top);
                Console.Write('X');
            }
        }

        private static bool AcceptInput()
        {
            if (!Console.KeyAvailable)
                return false;

            _lastKey = Console.ReadKey();

            return true;
        }

        private static void Move(ConsoleKeyInfo key)
        {
            Position currentPos;
            if (points.Count != 0)
                currentPos = new Position() { left = points.Last().left, top = points.Last().top };
            else
                currentPos = GetStartPosition();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentPos.left--;
                    break;
                case ConsoleKey.RightArrow:
                    currentPos.left++;
                    break;
                case ConsoleKey.UpArrow:
                    currentPos.top--;
                    break;
                case ConsoleKey.DownArrow:
                    currentPos.top++;
                    break;
            }

            DetectCollision(currentPos);

            points.Add(currentPos);
        }

        private static void DetectCollision(Position currentPos)
        {

            // Check om vi er udefor skærmen
            if (currentPos.top < 0 || currentPos.top >= Console.WindowHeight
                || currentPos.left < 0 || currentPos.left >= Console.WindowWidth)
            {
                GameOver();
            }

            // Check om vi har spist et spørgsmålstegn
            if (shortCut.left == currentPos.left && shortCut.top == currentPos.top)
            {
                Done = false;
                ShortCut();
            }
        }

        public static void ShortCut()
        {
            Console.Clear();
            Console.WriteLine("You found the trapdoor, but is this to easy? should you look for other trapdoors?");
            Console.WriteLine("You decide to carry on thrug the trapdoor");
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to enter the trapdoor . . .");
            Console.ReadLine();
            Dialog.Blind();
        }
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("");
            Console.WriteLine("Press enter . . .");
            Console.ReadLine();
            TitleScreen.Difficulty();
        }

        private static Position GetStartPosition()
        {
            return new Position()
            {
                left = 0,
                top = 0
            };
        }
    }
}
