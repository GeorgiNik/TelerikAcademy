namespace rpg_Game_V1.Weapons
{
    using System.Text;

    using Weapons.Interface;

    public class DarkStaff:Weapon,IWeapon
    {  
        public DarkStaff(string name, int dmg, int acc,int manaCost, string imageLocation)
            : base(imageLocation)
        {
            this.Name = name;
            this.DmgValue = dmg;
            this.AccuracyRating = acc;
            this.ManaCost = manaCost;
            this.StaminaCost = 0;
            this.EquipmentCost = 1;
        }

        public int ManaCost { get; set; }
        public int StaminaCost { get; set; }    

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("   ∙ Dmg: {0,-4}  Ar: {1,-4}  Mc: {2,-4}", this.DmgValue, this.AccuracyRating, this.ManaCost));
            return sb.ToString();
        }
    }
}
