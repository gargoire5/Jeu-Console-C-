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
        Model model = new Model();
        public SceneMenu()
        {
            Console.Clear();
            Console.WriteLine(model.menu);
            Update();
        }
        public void Update()
        {
            int bruh = 0;
            while (bruh == 0)
            {
                Console.SetCursorPosition(0, 0);
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.P))
                {
                    new SceneGame();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    bruh = 1;
                }
            }

        }
    }
    public class SceneGame
    {
        Model model = new Model();
        public SceneGame()
        {
            Console.Clear();
            Console.WriteLine(model.dingus);
            Update();
        }
        public void Update()
        {
            while (true)
            {
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.M))
                {
                    new SceneMap();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.T))
                {
                    new SceneTeam();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Escape))
                {
                    new SceneMenu();
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

    public class SceneTeam
    {
        Game game = new Game();
        Model model = new Model();
        public SceneTeam()
        {
            Console.Clear();
            game.Team();
            Update();
        }
        public void Update()
        {
            int bruh = 0;
            while (bruh == 0)
            {
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.T))
                {
                    Console.Clear();
                    Console.WriteLine(model.dingus);
                    bruh = 1;
                }
            }
        }

    }

    public class SceneMap
    {
        Model model = new Model();
        public SceneMap()
        {
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
                    Console.WriteLine(model.dingus);
                    bruh = 1;
                }
            }
        }

    }
}