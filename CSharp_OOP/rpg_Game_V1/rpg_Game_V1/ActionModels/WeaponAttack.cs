namespace rpg_Game_V1.ActionModels
{
    using System;

    using AbilityModels;
    using ActionModels.Interface;
    using EntityModels;

    public class WeaponAttack : OffensiveA, IOffensive
    {
        public WeaponAttack(Player p1, Enemy p2, LightAttackAbility a1)
            : base(p1, p2, a1)
        {
            var temp = a1;
            this.DmgValue = temp.HealtDmg;
            this.ManaEffect = temp.ManaEffect;
            this.StaminaEffect = temp.StaminaEffect;

            if (p2.Info.DefenceRating > temp.HitModf)
            {
                this.Defend = true;
            }
            else
            {
                this.Defend = false;                
            }
        }

        public WeaponAttack(Enemy p1, Player p2, LightAttackAbility a1)
            : base(p1, p2, a1)
        {
            var temp = a1;
            this.DmgValue = temp.HealtDmg;
            this.ManaEffect = temp.ManaEffect;
            this.StaminaEffect = temp.StaminaEffect;

            if (p2.Info.DefenceRating > temp.HitModf)
            {
                this.Defend = true;
            }
            else
            {
                this.Defend = false;
            }
        }

        public int DmgValue { get; set; }
        //public string ID { get; set; }
        public int ManaEffect { get; set; }
        public int StaminaEffect { get; set; }
        public bool Defend { get; set; }
     
        public int Resolve()
        {
            this.Orgin.ChangeMana(-this.ManaEffect);
            this.Orgin.ChangeStamina(-this.StaminaEffect);

            if (this.Defend == false)
            {
                this.Target.ChangeHealth(-this.DmgValue);
                return 1;
            }
            else
            {
                // Console.WriteLine("Blocked");
                return 0;
            }
        }        
    }
}
