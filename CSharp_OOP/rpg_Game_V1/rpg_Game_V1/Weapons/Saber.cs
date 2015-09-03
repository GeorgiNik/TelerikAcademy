namespace rpg_Game_V1.Weapons
{
    using System.Text;

    using rpg_Game_V1.AbilityModels;
    using rpg_Game_V1.Weapons.Interface;

    public class Saber : Weapon, IWeapon
    {
        public int StaminaCost { get; set; }
        public int ManaCost { get; set; }

        public Saber(string name, int dmg, int acc,int staminacost, string imageLocation)
            : base(imageLocation)
        {
            this.Name = name;
            this.DmgValue = dmg;
            this.AccuracyRating = acc;
            this.StaminaCost = staminacost;
            
            this.EquipmentCost = 1;
        }

        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("   ∙ Dmg: {0,-4}  Ar: {1,-4}  Sc: {2,-4}", this.DmgValue, this.AccuracyRating, this.StaminaCost));
            return sb.ToString();
        }


       
    }
}
