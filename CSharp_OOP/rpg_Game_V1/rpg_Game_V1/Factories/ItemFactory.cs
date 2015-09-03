namespace rpg_Game_V1.Factories
{
    using System;
    using System.Collections.Generic;

    using rpg_Game_V1.Weapons;
    using rpg_Game_V1.Weapons.Names;

    public static class ItemFactory
    {
        private const string ImagePath = "../../../Media/Items/{0}.png";

        private static Random Rnd = new Random();
        private static List<Items> ListOfItems = new List<Items>();
        private static int GenerateTimesLimit = 0;        

        public static  Items CreateRandomItem()
        {
            if (GenerateTimesLimit < 2)
            {
                AddRandomItems(ListOfItems);
            }            
            int item = Rnd.Next(0, ListOfItems.Count);
            //ListOfItems.Clear();
            return ListOfItems[item];
        }

        private static void AddRandomItems(List<Items> ListOfItems)
        {          
            // SABERS
            ListOfItems.Add(new Saber(SaberNames.Excalibur.ToString(), Rnd.Next(10, 100), Rnd.Next(10, 100), Rnd.Next(0, 5), string.Format(ImagePath, SaberNames.Excalibur)));
            ListOfItems.Add(new Saber(SaberNames.Glamdring.ToString(), Rnd.Next(10, 100), Rnd.Next(10, 100), Rnd.Next(0, 3), string.Format(ImagePath, SaberNames.Glamdring)));
            ListOfItems.Add(new Saber(SaberNames.Valyrian.ToString(), Rnd.Next(10, 100), Rnd.Next(10, 100), Rnd.Next(1, 3), string.Format(ImagePath, SaberNames.Valyrian)));

            // DARK STAFFS
            ListOfItems.Add(new DarkStaff(DarkStaffNames.Thyrsus.ToString(), Rnd.Next(10, 100), Rnd.Next(10, 100), Rnd.Next(1, 10), string.Format(ImagePath, DarkStaffNames.Thyrsus.ToString())));
            ListOfItems.Add(new DarkStaff(DarkStaffNames.Toyaga.ToString(), Rnd.Next(10, 100), Rnd.Next(10, 200), Rnd.Next(2, 20), string.Format(ImagePath, DarkStaffNames.Toyaga.ToString())));

            // TRINKETS
            ListOfItems.Add(new Trinket(TrinketsNames.DraupnirRing.ToString(), Rnd.Next(10, 100), Rnd.Next(0, 2), Rnd.Next(2, 20), string.Format(ImagePath, TrinketsNames.DraupnirRing.ToString())));
            ListOfItems.Add(new Trinket(TrinketsNames.ThePrecious.ToString(), Rnd.Next(10, 100), Rnd.Next(0, 2), Rnd.Next(2, 20), string.Format(ImagePath, TrinketsNames.ThePrecious.ToString())));

            // ARMORS
            ListOfItems.Add(new PlateArmor(PlateArmorsNames.Achilles.ToString(), Rnd.Next(20, 150), string.Format(ImagePath, PlateArmorsNames.Achilles.ToString())));
            ListOfItems.Add(new PlateArmor(PlateArmorsNames.Karna.ToString(), Rnd.Next(20, 150), string.Format(ImagePath, PlateArmorsNames.Karna.ToString())));
        }
    }
}
