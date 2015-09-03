namespace rpg_Game_V1.Render
{
    using System.Windows.Forms;

    using EntityModels;
    
    class Renderer
    {
        public void OpenComabatScreen(Enemy opponent)
        {
            var imageUri = opponent.Image;
            Application.Run(new CombatScreen(imageUri));
        }
    }
}
