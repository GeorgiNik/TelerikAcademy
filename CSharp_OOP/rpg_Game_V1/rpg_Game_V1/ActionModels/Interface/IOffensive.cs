namespace rpg_Game_V1.ActionModels.Interface
{
    public interface IOffensive
    {
        

        int DmgValue { get; set; }
        
        int ManaEffect { get; set; }
        int StaminaEffect { get; set; }
        bool Defend { get; set; }

        int Resolve();
    }
}
