namespace rpg_Game_V1.EntityModels
{
    using EntityModels.Interfaces;

    public abstract class GoodEntity : Entity,IEntity
    {
        public GoodEntity(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, int defenceRation)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght,defenceRation)
        {
            this.IsGood = true;
        }

        public bool IsGood { get; private set; }
    }
}
