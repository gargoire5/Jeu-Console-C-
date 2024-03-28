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
            string centeredMenu = model.CenterText(model.menu);
            Console.WriteLine(centeredMenu);
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
                    bruh = 1;
                    new SceneGame();
                }
                
                if (InputManager.IsKeyPressed(ConsoleKey.Q))
                {
                    bruh = 1;
                }
            }

        }
    }
    internal class SceneGame
    {
        Model model;
        Player player;
        SceneTeam? sceneTeam = null;
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
                    Console.Clear() ;
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

    internal class SceneTeam
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
        Potion potion = new Potion("Potion", "Rend 20 PV à un Pokemon", 0);

        public SceneTeam()
        {
            Console.Clear();
            team.AddPokemon(Gianni);
            team.AddPokemon(Ewen);
            team.AddPokemon(Enzo);
            team.RemoveHp(Gianni, 5);
            team.RemoveHp(Ewen, 12);
            team.RemoveHp(Enzo, 2);
            Update();
        }
        public void ApplyPotionToSelectedTechmons(Potion potion)
        {
            Techmons selectedTechmons = team.GetSelectedTechmons();

            potion.UsePotion(selectedTechmons);

            potion.Quantity -= 1;

            Update();

            
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
                    case ConsoleKey.Enter:
                        ApplyPotionToSelectedTechmons(potion);
                        break;
                }
            }
        }

    }

    internal class SceneInventory
    {
        Game game = new Game();
        Model model = new Model();
        Inventory inventory = new Inventory();
        SceneTeam sceneTeam;
        Potion potion = new Potion("Potion", "Rend 20 PV à un Pokemon", 0);
        Items TechBalls = new Items("Techball", "Permet de capturer un pokemon", 0);

        public SceneInventory(SceneTeam sceneTeam)
        {
            Console.Clear();
            if (sceneTeam != null)
            {
                this.sceneTeam = sceneTeam;
                Update();
            }
            else
            {
                Console.WriteLine("Erreur: SceneTeam n'est pas initialisé.");
            }
        }

        public void Update()
        {
            inventory.AddItems(potion, 5);
            inventory.AddItems(TechBalls, 10);

            bool inventActive = true;

            // Afficher l'inventaire et gérer les interactions avec l'utilisateur
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
                        Items selectedItem = inventory.UseSelectedItem(sceneTeam);
                        if (selectedItem == null)
                        {
                            Console.WriteLine("Cet objet ne peut pas être utilisé.");
                        }
                        break;

                    case ConsoleKey.Escape:
                        return;
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