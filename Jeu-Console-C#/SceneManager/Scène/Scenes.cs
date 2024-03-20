using Jeu_Console_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenes
{
    public class SceneMenu
    {
        Model model = new Model();
        public SceneMenu()
        {
            Console.WriteLine(model.menu);
            Update();
        }
        public void Update()
        {
            while (true)
            {
                Console.SetCursorPosition(0,0);
            }
            
        }
    }
    public class SceneGame
    {
        public void Update()
        {

        }

    }
    public class SceneFight
    {
        public void Update()
        {

        }

    }
    public class SceneMap : SceneManager
    {
        override public void Update()
        {

        }

    }
}
