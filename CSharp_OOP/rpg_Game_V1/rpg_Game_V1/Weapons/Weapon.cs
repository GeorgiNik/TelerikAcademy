namespace rpg_Game_V1.Weapons
{
    public abstract class Weapon : Items
    {

        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
        
        public Weapon(string imageLocation)
            : base(imageLocation)
        { 
        }

        
    }
}
