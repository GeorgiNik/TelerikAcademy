namespace rpg_Game_V1.AbilityModels
{
    public abstract class Ability
    {        
        public virtual string AbilityType
        {
            get
            {
                return "Non";
            }
        }

        public string Name { get; set; }
        public int StaminaEffect { get; set; }
        public int ManaEffect { get; set; }
    }
}
