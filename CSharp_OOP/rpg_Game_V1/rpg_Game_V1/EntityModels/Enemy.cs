namespace rpg_Game_V1.EntityModels
{
    using System;
    using System.Collections.Generic;

    using rpg_Game_V1.AbilityModels;
    using rpg_Game_V1.EntityModels.Interfaces;
    using rpg_Game_V1.Factories;
    using rpg_Game_V1.Weapons;

    public class Enemy:BadEntity,IEntity
    {
        List<AttackAbility> attacks = new List<AttackAbility>();
        Random rng = new Random();
        Items dropItem;        

        public Enemy(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, string imageLoc, int defenceRation)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght,defenceRation)
        {
            this.Image = imageLoc;
            this.dropItem = ItemFactory.CreateRandomItem();
        }

        private int DoAttack(Player target, Ability a)
        {
            var skill = (LightAttackAbility)a;
            var action = skill.CreatAction(this, target);
            var resolution = action;
            var r = resolution.Resolve();

            return r;
        }

        public string Image { get; set; }

        public void AddAbility(LightAttackAbility a)
        {
            attacks.Add(a);
        }        

        public int DoAttack(Player target, int n)
        {
            var r = -1;            
            int ch = n;

            if (ch < 0) 
            { 
                return -1; 
            }   
         
            var tempattack = (LightAttackAbility)this.attacks[ch];
           
            r = this.DoAttack(target, tempattack);
            
            return r;
        }      
    }
}
