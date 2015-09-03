namespace rpg_Game_V1.AbilityModels.Interface
{
    using ActionModels;
    using rpg_Game_V1.EntityModels;

    public interface IAbility<T>
    {
        int HealtDmg { get; set; }
        int StaminaEffect { get; set; }
        int ManaEffect { get; set; }
        string Name { get; set; }

        T CreatAction(Entity origin, Entity target);
    }
}
