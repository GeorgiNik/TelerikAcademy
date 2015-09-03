namespace rpg_Game_V1.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using rpg_Game_V1.EntityModels;
    using rpg_Game_V1.EntityModels.Interfaces;
    using rpg_Game_V1.AbilityModels;
    using rpg_Game_V1.AbilityModels.Interface;
    using rpg_Game_V1.ActionModels;
    using rpg_Game_V1.ActionModels.Interface;
    using rpg_Game_V1.Weapons;
    using rpg_Game_V1.Weapons.Interface;

    public class MobFactory
    {
        private static Random RndGenertor = new Random();

        private MobFactory()
        { 
        }

        private static readonly MobFactory instance = new MobFactory();

        public static MobFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public Enemy CreateEnemy()
        {        
            string name = SelectRandomEnemyType();
            int health = RndGenertor.Next(50, 101);
            int mana = RndGenertor.Next(0, 101);
            int stamina = RndGenertor.Next(0, 11);
            int dexterity = RndGenertor.Next(0, 11);
            int intelligence = RndGenertor.Next(10, 11);
            int strenght = RndGenertor.Next(0, 11);
            int defenceRation = RndGenertor.Next(0, 11);
            string imageLocation = string.Format("../../../Media/{0}.jpg", name);

            Enemy newEnemy = new Enemy(name, health, mana, stamina, dexterity, intelligence, strenght, imageLocation, defenceRation);

            newEnemy.AddAbility(new LightAttackAbility(RndGenertor.Next(10, 50), RndGenertor.Next(10, 50), RndGenertor.Next(10, 50), RndGenertor.Next(10, 50), "attack"));
            return newEnemy;
        }

        private string SelectRandomEnemyType()
        {
            string[] names = Enum.GetNames(typeof(EnemyType));

            int randomEnum = RndGenertor.Next(names.Length);

            var type = Enum.Parse(typeof(EnemyType), names[randomEnum]);

            return type.ToString();        
        }
    }
}
