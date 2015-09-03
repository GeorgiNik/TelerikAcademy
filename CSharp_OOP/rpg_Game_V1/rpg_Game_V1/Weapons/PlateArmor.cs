namespace rpg_Game_V1.Weapons
{
    using AbilityModels;
    using Weapons.Interface;

    class PlateArmor : Armor, IArmor
    {     
        public PlateArmor(string name, int def, string imageLocation)
            : base(imageLocation)
        {
            this.Name = name;
            this.DefRatingMod = def;
        }

        public int DefRatingMod { get; set; }

        //public override Ability AddAbility()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
