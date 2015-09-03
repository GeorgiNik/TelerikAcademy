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

    using EntityModels;
    using Factories;

    public partial class CombatScreen : Form
    {
        public Player HumanPlayer { get; set; }
        public Enemy Mob { get; set; }
        Random rng = new Random();

        public CombatScreen()
        {
            InitializeComponent();
        }

        public CombatScreen(string imageLocation)
            : this()
        {            
            this.EnemyPicture.Load(imageLocation);
        }

        public CombatScreen(Player human, Enemy mob)
        {
            InitializeComponent();
            this.HumanPlayer = human;
            this.Mob = mob;
            this.label1.Text = this.HumanPlayer.ToString();
            this.label2.Text = this.Mob.ToString();
            this.label3.Text = this.HumanPlayer.Name;
            this.label4.Text = this.Mob.Name;
            this.EnemyPicture.Load(mob.Image);
            this.comboBox1.Items.AddRange(human.AbilityList());
            this.comboBox1.Items.Add("No Action");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = -1;
            if (this.comboBox1.SelectedIndex != this.comboBox1.Items.Count - 1)
            {
                r = this.HumanPlayer.DoAttack(this.Mob, this.comboBox1.SelectedIndex);
            }
            
            switch(r)
            {
                case 0:
                    this.HeroAttackResult.Load(@"../../../Media/miss.png");
                    break;
                case 1:
                    this.HeroAttackResult.Load(@"../../../Media/hit.png");
                    break;
                default:
                    this.HeroAttackResult.Load(@"../../../Media/noattack.png");
                    break;
            }
            if (r == -1) { this.HumanPlayer.ChangeStamina(1); }

            var r1 = this.Mob.DoAttack(this.HumanPlayer, 0);

            switch (r1)
            {
                case 0:
                    this.pictureBox2.Load(@"../../../Media/miss.png");
                    break;
                case 1:
                    this.pictureBox2.Load(@"../../../Media/hit.png");
                    break;
                default:
                    this.pictureBox2.Load(@"../../../Media/noattack.png");
                    break;
            }
            this.label1.Text = this.HumanPlayer.ToString();
            this.label2.Text = this.Mob.ToString();
            this.Update();

            if(this.HumanPlayer.Info.Health<=0||this.Mob.Info.Health<=0)
            {
                this.HumanPlayer.AddItem(ItemFactory.CreateRandomItem());
                this.Close();
            }

        }

        
    }
}
