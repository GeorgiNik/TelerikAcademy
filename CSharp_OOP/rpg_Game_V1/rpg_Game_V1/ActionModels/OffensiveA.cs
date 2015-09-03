namespace rpg_Game_V1.ActionModels
{
    using AbilityModels;
    using EntityModels;

    public abstract class OffensiveA : GameAction
    {    
        public OffensiveA(Entity p1, Entity p2, Ability a1)
            : base(p1, p2, a1)
        {          
        }

        public bool IsValid { get; set; }
    }
}
