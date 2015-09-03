namespace rpg_Game_V1
{
    using System;

    using rpg_Game_V1.EntityModels;
    using rpg_Game_V1.Factories;

    public class BattlePath
    {
        private Random rgn = new Random();

        public BattlePath()
        {
            this.mFactory = MobFactory.Instance;
            this.enemy = this.mFactory.CreateEnemy();
            this.player = new Player("Pavel", 100, 100, 5, 0, 0, 0, 0);

            for (int i = 0; i < this.rgn.Next(2, 7); i++)
            {
                var itemRnd = ItemFactory.CreateRandomItem();
                player.AddItem(itemRnd);
            }
        }

        public InventoryWindow inventoryScreen { get; set; }
        public CombatScreen battleScreen { get; set; }
        public Player player { get; set; }
        public Enemy enemy { get; set; }
        public MobFactory mFactory { get; set; }
    }
}
