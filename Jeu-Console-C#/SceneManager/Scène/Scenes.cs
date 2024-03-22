using Jeu_Console_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scenes
{
    public class SceneMenu
    {
        Model model;
        public SceneMenu()
        {
            model = new Model();
            Console.WriteLine(model.menu);
            Update();
        }
        public void Update()
        {
            int bruh = 0;
            while (bruh == 0)
            {
                Console.SetCursorPosition(0,0);
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.P))
                {
                    new SceneGame();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    Console.Clear();
                    bruh = 1;
                }
            }
            
        }
    }
    public class SceneGame
    {
        Model model;
        Player player;
        public SceneGame()
        {
            model = new Model();
            player = new Player(15,15);
            Console.Clear();
            Console.WriteLine(model.mario);
            Update();
        }
        public void Update()
        {
            Console.SetCursorPosition(player.playerX, player.playerY);
            Console.Write("@"); 
            while (true)
            {
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.Z))
                {
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write(" ");
                    player.playerY = player.playerY - 1;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                }
                if (InputManager.IsKeyPressed(ConsoleKey.S))
                {
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write(" ");
                    player.playerY = player.playerY + 1;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                }
                if (InputManager.IsKeyPressed(ConsoleKey.D))
                {
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write(" ");
                    player.playerX = player.playerX + 1;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write(" ");
                    player.playerX = player.playerX -+ 1;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                }
                if (InputManager.IsKeyPressed(ConsoleKey.M))
                {
                    new SceneMap();
                }
            }
        }
    }
    public class SceneFight
    {
        Model model = new Model();
        public void Update()
        {

        }

    }
    public class SceneMap
    {
        Model model;
        public SceneMap()
        {
            model = new Model();
            Console.Clear();
            Console.WriteLine(model.map);
            Update();
        }
        public void Update()
        {
            int bruh = 0;
            while (bruh == 0)
            {
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.M))
                {
                    Console.Clear();
                    Console.WriteLine(model.mario);
                    bruh = 1;
                }
            }
        }

    }
}
