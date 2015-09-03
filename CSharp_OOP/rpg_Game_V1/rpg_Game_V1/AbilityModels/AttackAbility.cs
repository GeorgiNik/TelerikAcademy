namespace rpg_Game_V1.AbilityModels
{
    using AbilityModels.Interface;
    using ActionModels;

    public abstract class AttackAbility:Ability
    {
        
        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }
    }
}
