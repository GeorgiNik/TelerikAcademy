namespace rpg_Game_V1.AbilityModels
{
    using System;

    using ActionModels;
    using EntityModels;
    using Weapons;
    using rpg_Game_V1.AbilityModels.Interface;

    class LightMagicAbility:AttackAbility,IAbility<MagicAttack>
    {
        public int HealtDmg { get; set; }
        
        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }

        public LightMagicAbility(int healthDamage, int staminaCost, int manaCost, int hitPercent, string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.HitModf = hitPercent;
            this.Name = name;
        }
        public LightMagicAbility(DarkStaff staff)
        {
            this.HealtDmg = staff.DmgValue ;
            this.ManaEffect = staff.ManaCost;
            this.StaminaEffect = 0;
            this.HitModf = staff.AccuracyRating;
            this.Name = staff.Name + " Light Attack";
        }
       
        public LightMagicAbility(DarkStaff staff,Entity owner)
        {
            this.HealtDmg = staff.DmgValue + owner.Info.Int;
            this.ManaEffect = staff.ManaCost;
            this.StaminaEffect = 0;
            this.HitModf = staff.AccuracyRating;
            this.Name = staff.Name + " Light Magic Attack";
        }
        public MagicAttack CreatAction(Entity origin,Entity target)
        {
            if (origin is Player)
            {
                var player = (Player)origin;
                var mob = (Enemy)target;
                return new MagicAttack(player, mob, this);
            }
            else
            {
                var player = (Enemy)origin;
                var mob = (Player)target;
                return new MagicAttack(player, mob, this);
            }
        }

        public override string ToString()
        {
            return this.Name + string.Format(" - Sc: {0}", this.StaminaEffect);
        }





    }
 }

