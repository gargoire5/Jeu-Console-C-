using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class InputManager 
    {

        private static bool keyPressed = false;
        private static ConsoleKeyInfo lastKeyPress;
        
        public static void ReadKey()
        {
            if (Console.KeyAvailable)
            {
                lastKeyPress = Console.ReadKey(intercept: true);
                keyPressed = true;
            }
            else
            {
                keyPressed = false;
            }
        }

        public static bool IsKeyPressed(ConsoleKey key)
        {
            if (keyPressed && lastKeyPress.Key == key)
            {
                keyPressed = false;
                return true;
            }
            return false;
        }

        public static ConsoleKeyInfo GetKeyPressed()
        {
            return lastKeyPress;
        }
    }
}