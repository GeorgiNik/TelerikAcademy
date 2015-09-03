namespace rpg_Game_V1.ActionModels.Interface
{
    public interface IHealer
    {
        int DmgValue { get; set; }
       
        int ManaEffect { get; set; }
        int StaminaEffect { get; set; }

        int Resolve();        
    }
}
