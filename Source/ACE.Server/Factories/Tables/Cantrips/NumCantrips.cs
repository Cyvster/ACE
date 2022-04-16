using System.Collections.Generic;

using ACE.Database.Models.World;
using ACE.Server.Factories.Entity;

namespace ACE.Server.Factories.Tables
{
    public static class NumCantrips
    {
        private static ChanceTable<int> T1_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.05f ),
            ( 1, 0.95f ),
        };

        private static ChanceTable<int> T2_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.95f ),
            ( 1, 0.05f ),
        };

        private static ChanceTable<int> T3_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.10f ),
            ( 1, 0.20f ),
            ( 2, 0.70f ),
        };

        private static ChanceTable<int> T4_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.10f ),
            ( 1, 0.10f ),
            ( 2, 0.10f ),
            ( 3, 0.70f ),
        };

        private static ChanceTable<int> T5_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.05f ),
            ( 1, 0.05f ),
            ( 2, 0.05f ),
            ( 3, 0.10f ),
            ( 4, 0.75f ),
        };

        private static ChanceTable<int> T6_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.05f ),
            ( 1, 0.05f ),
            ( 2, 0.05f ),
            ( 3, 0.05f ),
            ( 4, 0.05f ),
            ( 5, 0.75f ),
        };

        private static ChanceTable<int> T7_T8_NumCantrips = new ChanceTable<int>()
        {
            ( 1, 0.05f ),
            ( 2, 0.05f ),
            ( 3, 0.10f ),
            ( 4, 0.75f ),
        };

        private static readonly List<ChanceTable<int>> numCantrips = new List<ChanceTable<int>>()
        {
            T1_NumCantrips,
            T2_NumCantrips,
            T3_NumCantrips,
            T4_NumCantrips,
            T5_NumCantrips,
            T6_NumCantrips,
            T7_T8_NumCantrips,
            T7_T8_NumCantrips,
        };

        public static int RollNumCantrips(TreasureDeath profile)
        {
            return numCantrips[profile.Tier - 1].Roll(profile.LootQualityMod);
        }

        private static ChanceTable<int> T1_T2_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 1.0f )
        };

        private static ChanceTable<int> T3_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.97f ),
            ( 2, 0.03f ),
        };

        private static ChanceTable<int> T4_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.90f ),
            ( 2, 0.10f ),
        };

        private static ChanceTable<int> T5_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.85f ),
            ( 2, 0.15f ),
        };

        private static ChanceTable<int> T6_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.80f ),
            ( 2, 0.20f ),
        };

        private static ChanceTable<int> T7_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.01f ),
            ( 2, 0.01f ),
            ( 3, 0.98f )
        };

        private static ChanceTable<int> T8_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.005f ),
            ( 2, 0.005f ),
            ( 3, 0.010f ),
            ( 4, 0.980f )
        };

        private static readonly List<ChanceTable<int>> cantripLevels = new List<ChanceTable<int>>()
        {
            T1_T2_CantripLevel,
            T1_T2_CantripLevel,
            T3_CantripLevel,
            T4_CantripLevel,
            T5_CantripLevel,
            T6_CantripLevel,
            T7_CantripLevel,
            T8_CantripLevel,
        };

        public static int RollCantripLevel(TreasureDeath profile)
        {
            return cantripLevels[profile.Tier - 1].Roll(profile.LootQualityMod);
        }
    }
}
