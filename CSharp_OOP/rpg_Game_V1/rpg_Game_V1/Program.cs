namespace rpg_Game_V1
{  
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using rpg_Game_V1.Factories;
    using rpg_Game_V1.AbilityModels;
    using rpg_Game_V1.EntityModels;
    using rpg_Game_V1.Render;
    using rpg_Game_V1.Weapons;

    static class Program
    {
        public static void Main()
        {
            InitialiseGame();
           
        }

        public static void  InitialiseGame()
        {
            var Battle = new BattlePath();
            var choiceWindow = new ChoiceWindow(Battle);
            choiceWindow.ShowDialog();
        }
    }
}
