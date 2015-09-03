namespace rpg_Game_V1.EntityModels
{
    using System.Text;

    using EntityModels.Interfaces;

    public abstract class Entity:IEntity
    {
        public Entity(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, int defenceRation)
        {
            this.Name = name;
            this.Info = new EntityStats(health, mana, stamina, dexterity, intelligence, strenght,defenceRation);
        }

        public EntityStats Info { get; set; }
        public string Name { get; set; }

        public void ChangeHealth(int health)
        {
            var h = this.Info.Health+health;
            var m = this.Info.Mana;
            var s = this.Info.Stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;
            var dr = this.Info.DefenceRating;

            this.Info = new EntityStats(h, m, s, d, i, str,dr);
        }

        public void ChangeMana(int mana)
        {
            var h = this.Info.Health;
            var m = this.Info.Mana+mana;
            var s = this.Info.Stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;
            var dr = this.Info.DefenceRating;

            this.Info = new EntityStats(h, m, s, d, i, str, dr);
        }

        public void ChangeStamina(int stamina)
        {
            var h = this.Info.Health;
            var m = this.Info.Mana;
            var s = this.Info.Stamina+stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;
            var dr = this.Info.DefenceRating;

            this.Info = new EntityStats(h, m, s, d, i, str, dr);
        }

        public void ChangeDefence(int def)
        {
            var h = this.Info.Health;
            var m = this.Info.Mana;
            var s = this.Info.Stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;
            var dr = this.Info.DefenceRating+def;

            this.Info = new EntityStats(h, m, s, d, i, str, dr);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("Type: {0}", this.GetType().Name));
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            sb.Append(this.Info.ToString());
       
            return sb.ToString();
        }       
    }
}
