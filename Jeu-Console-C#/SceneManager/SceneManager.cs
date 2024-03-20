using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scenes;

namespace Jeu_Console_C_
{
    public class SceneManager
    {
        public SceneManager() {

        }
        public virtual void Update()
        {
            var menu = new SceneMenu();
        }
    }
}