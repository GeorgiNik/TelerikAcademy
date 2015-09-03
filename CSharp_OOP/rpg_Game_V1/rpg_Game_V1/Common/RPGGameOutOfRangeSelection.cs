namespace rpg_Game_V1.Common
{
    using System;

    public class RPGGameOutOfRangeSelection : ApplicationException
    {
        public RPGGameOutOfRangeSelection(string massage, int min, int max)
            : base(massage)
        {
            this.IndexMin = min;
            this.IndexMax = max;
        }

        public int IndexMin { get; private set; }
        public int IndexMax { get; private set; }
    }
}
