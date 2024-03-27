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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            model = new Model();
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
        Model model;
        Player player;
        SceneTeam sceneTeam;
        public SceneGame()
        {
            model = new Model();
            player = new Player(15, 15);
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
        Team team = new Team();

        Techmons Gianni = new Techmons("Gianni", 20, 20, TypeElement.Css, 5);
        Techmons Ewen = new Techmons("Ewen", 45, 45, TypeElement.Python, 12);
        Techmons Enzo = new Techmons("Enzo", 12, 12, TypeElement.C, 1);
        Techmons Kyllian = new Techmons("Kyllian", 62, 62, TypeElement.Python, 17);
        Techmons Benjamin = new Techmons("Benjamin", 26, 26, TypeElement.C, 7);
        Techmons Grégoire = new Techmons("Grégoire", 82, 82, TypeElement.Css, 21);

        public SceneTeam()
        {
            Console.Clear();
            Update();
        }
        public void Update()
        {
            team.AddPokemon(Gianni);
            team.AddPokemon(Ewen);
            team.RemoveHp(Gianni, 5);

            bool teamActive = true;
            while (teamActive)
            {
                Console.Clear();
                team.DisplayTeam();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.T:

                        Console.Clear();
                        Console.WriteLine(model.mario);
                        teamActive = false;
                        break;
                    case ConsoleKey.UpArrow:
                        team.MoveSelectionUp();
                        break;
                    case ConsoleKey.DownArrow:
                        team.MoveSelectionDown();
                        break;
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
            Potion Potions = new Potion("Potion", "Rend 20 PV à un Pokemon", 0);
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
                        Console.WriteLine(model.mario);
                        inventoryActive = false;
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