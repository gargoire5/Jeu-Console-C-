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
            //string centeredMenu = model.CenterText(model.menu);
            Console.WriteLine(model.menu);
            Update();
        }
        public void Update()
        {
            Game game = new Game();
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                InputManager.ReadKey();
                if (InputManager.IsKeyPressed(ConsoleKey.P))
                {
                    new SceneGame(game);
                }
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    //Console.Clear();
                    //Environment.Exit(0);
                }
            }

        }
    }
    public class SceneGame
    {
        private Game game; // Référence à Game
        private Model model = new Model();
        Player player;
        private List<Techmons> equipeAdverse = new List<Techmons>();

        public SceneGame(Game game)
        {
            this.game = game;
            model = new Model();
            Console.Clear();
            Console.WriteLine("\r\n\r\nBienvenue dans le jeu Techmon!");
            Console.Write("\r\n\r\nEntrez votre nom de joueur : ");
            string nomPlayer = Console.ReadLine();
            player = new Player(81, 16, nomPlayer);
            Console.WriteLine($"Bonjour, {player.Name}!");
            this.equipeAdverse = new List<Techmons>();

            Console.Clear();
            Update();
        }
        public void Update()
        {
            string map = model.couloir;
            int index = player.playerY * 89 + player.playerX;
            SceneTeam sceneTeam = new SceneTeam();
            SceneInventory sceneInvetory = new SceneInventory();
            Console.Clear();
            Console.WriteLine(map);
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
                    Console.SetCursorPosition(78, 13);
                    Console.Write("L");
                    if (index == 1590 || index == 1589 || index == 1591)
                    {
                        player.playerX = 75;
                        player.playerY = 3;
                    }
                    else if (index == 1548 || index == 1547 || index == 1546)
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
                if (map == model.mario && index == 1148)
                {
                    index = (player.playerY - 1) * 89 + player.playerX + 1;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("L");
                    Console.SetCursorPosition(0, 25);
                    Console.Write("Leo : \r\n\r\n   Le jour ou Gianni viendras demander de l'aide a Dylan tu pourras revenir me voir ");
                    player.playerX--;
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");
                }
                if (InputManager.IsKeyPressed(ConsoleKey.T))
                {
                    sceneTeam.Update();
                    Console.WriteLine(map);
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");

                }
                if (InputManager.IsKeyPressed(ConsoleKey.Escape))
                {
                    new SceneMenu();
                }
                if (InputManager.IsKeyPressed(ConsoleKey.I))
                {
                    sceneInvetory.Update();
                    Console.WriteLine(map);
                    Console.SetCursorPosition(player.playerX, player.playerY);
                    Console.Write("@");

                }
                if (InputManager.IsKeyPressed(ConsoleKey.O))
                {
                    game.DemarrerCombat(player, equipeAdverse);
                }

            }
        }
    }
    public class SceneFight
    {
        private readonly Action _demarrerCombat;
        private Model model = new Model();
        private string map; // Déclaration de la variable map

        public SceneFight(Action demarrerCombat)
        {
            _demarrerCombat = demarrerCombat;
            this.map = model.couloir; // Initialisation de map avec la valeur de model.couloir
        }

        public void Update()
        {
            if (map == model.couloir)
            {
                _demarrerCombat?.Invoke();
            }
        }
    }


    internal class SceneTeam
    {
        Game game = new Game();
        Model model = new Model();
        Game Techmons;
        Inventory inventory = new Inventory();
        Team team;

        Techmons gianni = new Techmons("Gianni", 100, TypeElement.Css, 1);
        Techmons ewen = new Techmons("Ewen", 100, TypeElement.Python, 1);
        Techmons enzo = new Techmons("Enzo", 100, TypeElement.C, 1);
        Techmons grégoire = new Techmons("Grégoire", 100, TypeElement.Css, 1);
        Techmons kyllian = new Techmons("Kyllian", 100, TypeElement.Python, 1);
        Techmons benjamin = new Techmons("Benjamin", 100, TypeElement.C, 1);

        public SceneTeam()
        {
            team = new Team();
            team.AddPokemon(gianni);
            team.AddPokemon(ewen);
            team.AddPokemon(enzo);

            team.RemoveHp(gianni, 5);
            team.RemoveHp(ewen, 12);
            team.RemoveHp(enzo, 2);

            team.DisplayTeam();
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
            inventory.AddItems(potion, 5);
            inventory.AddItems(TechBalls, 10);
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
                                            inventory.RemoveSelectedItem();
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
