namespace rpg_Game_V1.EntityModels
{
    using EntityModels.Interfaces;

    public abstract class BadEntity:Entity,IEntity
    {
        public BadEntity(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, int defenceRation)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght,defenceRation)
        {
            this.IsGood = false;
        }

        public bool IsGood { get; private set; }
    }
}
