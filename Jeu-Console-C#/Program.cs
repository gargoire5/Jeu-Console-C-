using Jeu_Console_C_;
using System;

class Program
{
    static void Main(string[] args)
    {
        var Model = new Model();
        Console.WriteLine(Model.dingus);

        var inputManager = new InputManager();

        Console.WriteLine("Appuyer sur Echapp pour quitter");

        bool running = false;
        while(!running)
        {
            if (inputManager.IsKeyPressed(ConsoleKey.Q))
            {
                running = true;
            }
            else
            {
                Console.WriteLine("Touche appuyée : ");
            }
        }

        Console.WriteLine("Fin du programme.");
    }
}
