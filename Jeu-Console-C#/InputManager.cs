using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class InputManager 
    {
        public bool IsKeyPressed(ConsoleKey key)
        {
            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                if(keyPressed.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}