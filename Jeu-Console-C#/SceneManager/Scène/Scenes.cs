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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            model = new Model();
            string centeredMenu = model.CenterText(model.menu);
            Console.WriteLine(centeredMenu);
            Update();
        }
        public void Update()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.P))
                {
                    new SceneGame();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }

        }
    }
    internal class SceneGame
    {
        Model model;
        Player player;
        SceneTeam sceneTeam;
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
                if (InputManager.IsKeyPressed(ConsoleKey.Z) || InputManager.IsKeyPressed(ConsoleKey.UpArrow))
                {
                    index = (player.playerY - 2) * 89 + player.playerX + 2;
                    if (map[index] == ' ')
                    {
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write(' ');
                        player.playerY = player.playerY - 1;
                        Console.SetCursorPosition(player.playerX, player.playerY);
                        Console.Write("@");
                    }

                }
                if (InputManager.IsKeyPressed(ConsoleKey.S) || InputManager.IsKeyPressed(ConsoleKey.DownArrow))
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
                if (InputManager.IsKeyPressed(ConsoleKey.D) || InputManager.IsKeyPressed(ConsoleKey.RightArrow))
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
                if (InputManager.IsKeyPressed(ConsoleKey.Q) || InputManager.IsKeyPressed(ConsoleKey.LeftArrow))
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
                    new SceneMap(map);
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");

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
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write(" ");
                    player.playerX = player.playerX - +1;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
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

                    new SceneInventory();

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

    internal class SceneTeam
    {
        Game game = new Game();
        Model model = new Model();
        Team team;
        Inventory inventory = new Inventory();

        Techmons Gianni = new Techmons("Gianni", 20, 20, TypeElement.Css, 5);
        Techmons Ewen = new Techmons("Ewen", 45, 45, TypeElement.Python, 12);
        Techmons Enzo = new Techmons("Enzo", 12, 12, TypeElement.C, 1);
        Techmons Kyllian = new Techmons("Kyllian", 62, 62, TypeElement.Python, 17);
        Techmons Benjamin = new Techmons("Benjamin", 26, 26, TypeElement.C, 7);
        Techmons Grégoire = new Techmons("Grégoire", 82, 82, TypeElement.Css, 21);

        public SceneTeam()
        {
            Console.Clear();
            team = new Team(); 
            team.AddPokemon(Gianni);
            team.AddPokemon(Ewen);
            team.AddPokemon(Enzo);

            team.RemoveHp(Gianni, 5);
            team.RemoveHp(Ewen, 12);
            team.RemoveHp(Enzo, 2);

            team.DisplayTeam();

            Update();
        }

        public Team GetTeam()
        {
            return team;
        }

        public void Update()
        {
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

    internal class SceneInventory
    {
        Model model = new Model();
        Inventory inventory = new Inventory();
        List<Items> initialItems = new List<Items>();
        SceneTeam sceneTeam;
        Potion potion = new Potion("Potion", "Rend 20 PV à un Pokemon", 0);
        Items TechBalls = new Items("Techball", "Permet de capturer un pokemon", 0);

        public SceneInventory()
        {
            Console.Clear();
            inventory.AddItems(potion, 5);
            inventory.AddItems(TechBalls, 10);
            inventory.CopyFrom(initialItems);
            Update();
        }


        private void InitializeSceneTeamIfNeeded()
        {
            if (sceneTeam == null)
            {
                sceneTeam = new SceneTeam();
            }
        }

        public void Update()
        {
            bool inventActive = true;

            while (inventActive)
            {
                Console.Clear();
                inventory.DisplayInventory();
                Console.WriteLine("Sélectionnez un objet et appuyez sur Entrée pour l'utiliser.");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {

                    case ConsoleKey.I:
                        Console.Clear();
                        Console.WriteLine(model.mario);
                        inventActive = false;
                        break;
                    case ConsoleKey.UpArrow:
                        inventory.MoveSelectionUp();
                        break;
                    case ConsoleKey.DownArrow:
                        inventory.MoveSelectionDown();
                        break;
                    case ConsoleKey.Enter:

                        Items selectedItem = inventory.GetSelectedItem();
                        if (selectedItem != null && selectedItem is Potion potion)
                        {

                            InitializeSceneTeamIfNeeded();

                            Team team = sceneTeam.GetTeam();
                            team.DisplayTeam();
                            Console.WriteLine("Sélectionnez le Pokémon sur lequel utiliser la potion:");

                            
                            bool selected = false;
                            int selectedIndex = 0;
                            bool displayUpdated = false;

                            while (!selected)
                            {
                                if (displayUpdated) 
                                {
                                    Console.Clear(); 
                                    team.DisplayTeam(); 
                                    Console.WriteLine("Sélectionnez le Pokémon sur lequel utiliser la potion:");
                                    displayUpdated = false; 
                                }

                                ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);
                                switch (keyInfo1.Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        team.MoveSelectionUp();
                                        selectedIndex--;
                                        displayUpdated = true; 
                                        break;
                                    case ConsoleKey.DownArrow:
                                        team.MoveSelectionDown();
                                        selectedIndex++;
                                        displayUpdated = true; 
                                        break;
                                    case ConsoleKey.Enter:
                                        Techmons selectedTechmons = team.GetSelectedTechmons();
                                        if (selectedTechmons != null)
                                        {
                                            potion.UsePotion(selectedTechmons);
                                            inventory.RemoveItems(potion, 1);
                                            Console.WriteLine("La potion a été utilisée sur " + selectedTechmons.Name);
                                            selected = true;
                                        }
                                        break;
                                }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Cet objet ne peut pas être utilisé.");
                        }
                        break;


                    case ConsoleKey.Escape:
                        return;
                }

                System.Threading.Thread.Sleep(500);
            }
        }
    }


    public class SceneMap
    {
        Model model;
        public SceneMap(string Map)
        {
            model = new Model();
            string map = Map;
            Console.Clear();
            Console.WriteLine(model.map);
            Update(map);
        }
        public void Update(string Map)
        {
            string map = Map;
            int bruh = 0;
            while (bruh == 0)
            {
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.M))
                {
                    Console.Clear();
                    Console.WriteLine(map);
                    bruh = 1;
                }
            }
        }

    }
}