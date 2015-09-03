namespace rpg_Game_V1.Weapons
{
    using System;

    using rpg_Game_V1.AbilityModels;    

    public abstract class Items
    {   
        public Items(string imageLocation)
        {
            this.Image = imageLocation;
        }

        public string Name { get; set; }
        public int EquipmentCost { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return this.GetType().Name +  ":"  + Environment.NewLine + this.Name + " - used slots: " + this.EquipmentCost;
        }
    }   
}
