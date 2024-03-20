using Jeu_Console_C_;
using System;

class Program
{
    static void Main(string[] args)
    {
        var Model = new Model();
        Console.WriteLine(Model.dingus);

        EventManager eventManager = new EventManager();

        bool running = true;

        while (running)
        {
            running = eventManager.UpdateMenu();
        }

        Environment.Exit(0);
    }
}
