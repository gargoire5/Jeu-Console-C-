using Jeu_Console_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
            player = new Player(81,16);
            Console.Clear();
            Console.WriteLine(model.couloir);
            Update();
        }
        public void Update()
        {
            string map = model.couloir;
            int index = player.playerY * 89 + player.playerX;
            Console.SetCursorPosition(player.playerX, player.playerY);
            Console.Write("@"); 
            while (true)
            {
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.Z))
                {
                    index = (player.playerY - 2) * 89 + player.playerX + 2;
                    if (map[index] == ' ')
                    {
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write(index);
                        player.playerY = player.playerY - 1;
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write("@");
                    }

                }
                if (InputManager.IsKeyPressed(ConsoleKey.S))
                {
                    index = (player.playerY) * 89 + player.playerX + 2;
                    if (map[index] == ' ')
                    {
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write(' ');
                        player.playerY = player.playerY + 1;
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write("@");
                    }
                }
                if (InputManager.IsKeyPressed(ConsoleKey.D))
                {
                    index = (player.playerY - 1) * 89 + player.playerX + 3;
                    if (map[index] == ' ')
                    {
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write(' ');
                        player.playerX++;
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write("@");
                    }
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    index = (player.playerY - 1) * 89 + player.playerX + 1;
                    if (map[index] == ' ')
                    {
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write(' ');
                        player.playerX--;
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write("@");
                    }
                }
                if (InputManager.IsKeyPressed(ConsoleKey.M))
                {
                    new SceneMap();
                }
                if (map == model.couloir && index == 1590 || index == 1589 || index == 1591 || index == 1548 || index == 1547 || index == 1546)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(model.mario);
                    map = model.mario;
                    if (index == 1590 || index == 1589 || index == 1591)
                    {
                        player.playerX = 75;
                        player.playerY = 3;
                    }else if (index == 1548 || index == 1547 || index == 1546)
                    {
                        player.playerY = 3;
                        player.playerX = 32;
                    }
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                    index = player.playerY * 89 + player.playerX;
                }
                if (map == model.mario && index == 166 || index == 167 || index == 165 || index == 122 || index == 123 || index == 124)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Clear();
                    Console.WriteLine(model.couloir);
                    map = model.couloir;
                    if (index == 166 || index == 167 || index == 165)
                    {
                        player.playerX = 75;
                        player.playerY = 17;
                    }
                    else if (index == 122 || index == 123 || index == 124)
                    {
                        player.playerY = 17;
                        player.playerX = 32;
                    }
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                    index = player.playerY * 89 + player.playerX;
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
