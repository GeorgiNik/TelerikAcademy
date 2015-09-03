namespace rpg_Game_V1.ActionModels
{
    using rpg_Game_V1.AbilityModels;
    using rpg_Game_V1.EntityModels;

    public abstract class GameAction
    {
        public GameAction(Entity p1, Entity p2, Ability a1)
        {
            this.Orgin = p1;
            this.Target = p2;
        }

        public Entity Orgin { get; set; }
        public Entity Target { get; set; }
    }
}
