namespace rpg_Game_V1.EntityModels
{
    using System.Text;

    public struct EntityStats
    {
        public EntityStats(int health, int mana, int stamina, int dex, int intelligence, int strenght, int dr):this()
        {
            this.Health = health;
            this.Mana = mana;
            this.Stamina = stamina;
            this.Dex = dex;
            this.Int = intelligence;
            this.Str = strenght;
            this.DefenceRating = dr;
        }

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }

        public int Dex { get; set; }
        public int Int { get; set; }
        public int Str { get; set; }

        public int DefenceRating { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("Stats:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Health, "Health:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Mana, "Mana:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Stamina, "Stamina:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Dex, "Dexterity:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Int, "Intelligence:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Str, "Strength:"));
            sb.Append(string.Format(" - {1,-13} {0}", this.DefenceRating, "Defence:"));

            return sb.ToString();
        }
    }
}
