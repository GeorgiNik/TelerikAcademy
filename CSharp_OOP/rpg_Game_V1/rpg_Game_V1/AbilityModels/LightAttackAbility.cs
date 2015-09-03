namespace rpg_Game_V1.AbilityModels
{
    using System;

    using ActionModels;
    using EntityModels;
    using Weapons;
    using rpg_Game_V1.AbilityModels.Interface;    

    public class LightAttackAbility:AttackAbility,IAbility<WeaponAttack>
    {
        public LightAttackAbility(int healthDamage, int staminaCost, int manaCost, int hitPercent, string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.HitModf = hitPercent;
            this.Name = name;
        }

        public int HealtDmg { get; set; }
        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }

        public LightAttackAbility(Saber sword)
        {
            this.HealtDmg = sword.DmgValue;
            this.ManaEffect = 0;
            this.StaminaEffect = sword.StaminaCost;
            this.HitModf = sword.AccuracyRating;
            this.Name = sword.Name + " Light Attack";
        }

        public LightAttackAbility(Saber sword,Entity owner)
        {
            this.HealtDmg = sword.DmgValue + owner.Info.Str;
            this.ManaEffect = 0;
            this.StaminaEffect = sword.StaminaCost;
            this.HitModf = sword.AccuracyRating;
            this.Name = sword.Name + " Light Attack";
        }

        public WeaponAttack CreatAction(Entity origin,Entity target)
        {
            if (origin is Player)
            {
                var player = (Player)origin;
                var mob = (Enemy)target;
                return new WeaponAttack(player, mob, this);
            }
            else
            {
                var player = (Enemy)origin;
                var mob = (Player)target;
                return new WeaponAttack(player, mob, this);
            }
        }

        public override string ToString()
        {
            return this.Name + string.Format(" - Sc: {0}", this.StaminaEffect);
        }


        public GameAction CreatAction()
        {
            throw new NotImplementedException();
        }
    }
}
