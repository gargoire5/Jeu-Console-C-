using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class Player
    {
        public int playerX {  get; set; }
        public int playerY { get; set; }
        public Player(int X, int Y)
        {
            playerX = X; 
            playerY = Y;

        }
    }
}