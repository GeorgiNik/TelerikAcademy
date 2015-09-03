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

    public partial class LooseWindow : Form
    {
        public LooseWindow()
        {
            InitializeComponent();
            this.pictureBoxLooser.Load(@"../../../Media/LooseScreen.jpg");
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.InitialiseGame();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
