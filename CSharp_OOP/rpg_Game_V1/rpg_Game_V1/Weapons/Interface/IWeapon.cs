namespace rpg_Game_V1.Weapons.Interface
{
    public interface IWeapon
    {
        int DmgValue { get; set; }
        int StaminaCost { get; set; }
        int ManaCost { get; set; }
    }
}
