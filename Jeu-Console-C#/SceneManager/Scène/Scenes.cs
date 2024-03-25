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
            Console.ForegroundColor = ConsoleColor.Red;
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
        SceneTeam sceneTeam;
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
                    sceneTeam = new SceneTeam();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Escape))
                {
                    new SceneMenu();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.I))
                {
                   
                    new SceneInventory(sceneTeam);
                    
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

    public class SceneInventory
    {
        Game game = new Game();
        Model model = new Model();
        Inventory inventory = new Inventory();
        private SceneTeam sceneTeam;
        public SceneInventory(SceneTeam sceneTeam)
        {
            Console.Clear();
            this.sceneTeam = sceneTeam;
            Update();
        }
        public void Update()
        {
            Items Potions = new Items("Potion", "Rend 20 PV à un Pokemon", 0);
            Items TechBalls = new Items("Techball", "Permet de capturer un pokemon", 0);

            inventory.AddItems(Potions, 5);
            inventory.AddItems(TechBalls, 10);

            inventory.DisplayInventorry();

            bool inventoryActive = true;

            while (inventoryActive)
            {
                Console.Clear();

                inventory.DisplayInventorry();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.I:
                        Console.Clear();
                        Console.WriteLine(model.dingus);
                        break;
                    case ConsoleKey.UpArrow:
                        inventory.MoveSelectionUp();
                        break;
                    case ConsoleKey.DownArrow:
                        inventory.MoveSelectionDown();
                        break;
                    case ConsoleKey.Enter:
                        inventory.UseSelectedItem();
                        break;
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