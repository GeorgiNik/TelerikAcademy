namespace rpg_Game_V1
{    
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Engine;
    using EntityModels;
    using Factories;

    public partial class ChoiceWindow : Form
    {
        public BattlePath battlePath { get; set; }

        public ChoiceWindow()
        {
            InitializeComponent();
        }

        public ChoiceWindow(BattlePath bp)
            : this()
        {            
            foreach (var item in CoreEngine.OpenForms)
            {
                if(item is CombatScreen||item is LooseWindow)
                {
                    item.Close();
                }
            }

            this.battlePath = bp;
            this.labelStatsPlayer.Text = ScreenStats();            
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            this.battlePath.inventoryScreen = new InventoryWindow(this.battlePath.player);
           
            battlePath.inventoryScreen.ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.InitialiseGame();            
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (this.battlePath.player.Info.Health < 0)
            {
                var looser = new LooseWindow();
                this.Hide();
                looser.ShowDialog();
            }
            else
            {
                this.battlePath.enemy = this.battlePath.mFactory.CreateEnemy();
                this.battlePath.battleScreen = new CombatScreen(this.battlePath.player, this.battlePath.enemy);
                CoreEngine.OpenForms.Add(this.battlePath.battleScreen);
                this.battlePath.battleScreen.ShowDialog();
            }
        }

        private string ScreenStats()
        {
            var result = string.Format("Name: {0}, Health: {1}\n\rMana: {2}, Stamina: {3}\n\rDx: {4}, Int: {5}, Str: {6}, DR: {7}",
                this.battlePath.player.Name,
                this.battlePath.player.Info.Health, this.battlePath.player.Info.Mana, this.battlePath.player.Info.Stamina, this.battlePath.player.Info.Dex, this.battlePath.player.Info.Int, this.battlePath.player.Info.Str, this.battlePath.player.Info.DefenceRating);
            return result;
        }

        private void buttonRefreshStats_Click(object sender, EventArgs e)
        {
            this.labelStatsPlayer.Text = ScreenStats();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.battlePath.player.Name = this.textBox1.Text;
        }
    }
}
