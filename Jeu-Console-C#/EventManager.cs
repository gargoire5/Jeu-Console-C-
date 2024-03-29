using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    
    public class EventManager
    {
        public bool UpdateMenu()
        {

            InputManager.ReadKey();

            // Exit the Game
            if (InputManager.IsKeyPressed(ConsoleKey.Q))
            {

            }

            // Play the Game
            if (InputManager.IsKeyPressed(ConsoleKey.P))
            {
              
            }

            return true;
        }

        public bool Update() 
        {
            InputManager.ReadKey();

            // Deplacement du personnage
            if (InputManager.IsKeyPressed(ConsoleKey.UpArrow) || InputManager.IsKeyPressed(ConsoleKey.Z))
            {

            }

            if (InputManager.IsKeyPressed(ConsoleKey.DownArrow) || InputManager.IsKeyPressed(ConsoleKey.S))
            {

            }

            if (InputManager.IsKeyPressed(ConsoleKey.RightArrow) || InputManager.IsKeyPressed(ConsoleKey.D))
            {

            }

            if (InputManager.IsKeyPressed(ConsoleKey.LeftArrow) || InputManager.IsKeyPressed(ConsoleKey.Q))
            {

            }

            //Interaction
            if (InputManager.IsKeyPressed(ConsoleKey.E))
            {

            }

            //Inventaire
            if (InputManager.IsKeyPressed(ConsoleKey.I))
            {

            }

            //Menu
            if (InputManager.IsKeyPressed(ConsoleKey.Tab))
            {

            }

            //Map
            if (InputManager.IsKeyPressed(ConsoleKey.M))
            {

            }

            return true;
        }
    }


}
