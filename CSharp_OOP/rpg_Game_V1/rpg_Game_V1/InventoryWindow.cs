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
    using Weapons;
    using Common;

    public partial class InventoryWindow : Form
    {
        private const string EmptySlotPath = "../../../Media/Items/EmptySlot.png";        

        public InventoryWindow()
        {
            InitializeComponent();
        }

        public InventoryWindow(Player player)
            : this()
        {            
            this.Human = player;
            this.InventoryItems.Text = string.Join("\n", Human.Inventory );
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
            this.pictureBox1.Load(EmptySlotPath);
            this.pictureBox2.Load(EmptySlotPath);
            this.pictureBox3.Load(EmptySlotPath);
            this.pictureBox4.Load(EmptySlotPath);
            this.SetUpEquipment();
        }

        public Player Human { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private string[] ItemsNames()
        {
            var invet = this.Human.Inventory;

            var output = invet.Select(item => item.ToString()).ToArray();

            return  output;
        }

        private void buttonEquipItem_Click(object sender, EventArgs e)
        {
            var index = this.comboBoxEquip.SelectedIndex;

            if (index > this.Human.Inventory.Count - 1 || index < 0)
            {
                throw new RPGGameOutOfRangeSelection("Index out of range", 0, this.Human.Inventory.Count - 1);
            }

            var item = this.Human.Inventory[index];

            // Trinket before weapon because trinkit is weapon itself and sets as weapon
            if (item is Trinket)
            {
                this.Human.EqipTrinket(item);
            }
            else if(item is Weapon)
            {
                this.Human.EquipWeapon(item);
            }
            else if(item is Armor)
            {
                this.Human.EquipArmor(item);
            }            

            this.SetUpEquipment();
            this.InventoryItems.Text = string.Join("\n", Human.Inventory);
            this.comboBoxEquip.Items.Clear();
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
            this.comboBoxEquip.ResetText();
            this.Update();
        }

        private void SetUpEquipment()
        {
            this.comboBoxUnequip.Items.Clear();
            List<string> equipment = new List<string>();
            int count = 0;
            foreach (var item in this.Human.Equiped)
            {
                if (item is Trinket)
                {
                    this.pictureBox4.Load(item.Image);
                    this.StatsTrinketLabel.Text = item.ToString();
                }
                else if(item is Weapon)
                {
                    switch(count)
                    {
                        case 0:
                            this.pictureBox1.Load(item.Image);
                            // Labesls for Items stas starts with stats
                            this.StatsWeaponOneLabel.Text=item.ToString();
                            break;
                        case 1:
                            this.pictureBox2.Load(item.Image);
                            this.StatsWeaponTwooLabel.Text = item.ToString();
                            break;
                        default:
                            break;
                    }
                    count++;
                }
                else 
                {
               
                    this.pictureBox3.Load(item.Image);
                    this.StatsArmorLabel.Text = item.ToString();
                }               

                equipment.Add(item.ToString());
            }

            this.comboBoxUnequip.Items.AddRange(equipment.ToArray());
        }

        private void buttonUnequip_Click(object sender, EventArgs e)
        {
            var index = this.comboBoxUnequip.SelectedIndex;

            if (index > this.Human.Inventory.Count - 1 || index < 0)
            {
                throw new RPGGameOutOfRangeSelection("Index out of range", 0, this.Human.Inventory.Count - 1);
            }

            var item = this.Human.Equiped[index];

            if (item is Trinket)
            {
                this.Human.UneqipTrinket(item);
                this.pictureBox4.Load(EmptySlotPath);
                this.StatsTrinketLabel.Text = "";
                
            }
            else if(item is Armor)
            {
                this.Human.UneqipArmour(item);
                this.pictureBox3.Load(EmptySlotPath);
                this.StatsArmorLabel.Text = "";
            }
            else
            {
                this.Human.UneqipWeapon(item);

                if (this.Human.weaponCapacity == 1)
                {
                    if (item.ToString() == this.WeaponOneLabel.Text)
                    {
                        this.pictureBox1.Load(EmptySlotPath);
                        this.StatsWeaponOneLabel.Text = "";
                    }
                    else
                    {
                        this.pictureBox2.Load(EmptySlotPath);
                        this.StatsWeaponTwooLabel.Text = "";
                    }
                }
                else
                {
                    this.pictureBox1.Load(EmptySlotPath);
                    this.StatsWeaponOneLabel.Text = "";
                }
            }

            this.InventoryItems.Text = string.Join("\n", Human.Inventory);
            this.comboBoxEquip.Items.Clear();
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
            this.SetUpEquipment();

            this.comboBoxUnequip.ResetText();
            this.Update();
        }
    }
}

