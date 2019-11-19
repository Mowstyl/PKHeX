﻿namespace PKHeX.Core
{
    /// <summary>
    /// Ribbon Indexes for Generation 8
    /// </summary>
    public enum RibbonIndex
    {
        ChampionKalos,
        ChampionG3Hoenn,
        ChampionSinnoh,
        BestFriends,
        Training,
        BattlerSkillful,
        BattlerExpert,
        Effort,
        Alert,
        Shock,
        Downcast,
        Careless,
        Relax,
        Snooze,
        Smile,
        Gorgeous,
        Royal,
        GorgeousRoyal,
        Artist,
        Footprint,
        Record,
        Legend,
        Country,
        National,
        Earth,
        World,
        Classic,
        Premier,
        Event,
        Birthday,
        Special,
        Souvenir,
        Wishing,
        ChampionBattle,
        ChampionRegional,
        ChampionNational,
        ChampionWorld,
        MemoryContest,
        MemoryBattle,
        ChampionG6Hoenn,
        ContestStar,
        MasterCoolness,
        MasterBeauty,
        MasterCuteness,
        MasterCleverness,
        MasterToughness,
        ChampionAlola,
        BattleRoyale,
        BattleTreeGreat,
        BattleTreeMaster,
        ChampionGalar,
        TowerMaster,
        MasterRank,

        MarkLunchtime,
        MarkSleepyTime,
        MarkDusk,
        MarkDawn,
        MarkCloudy,
        MarkRainy,
        MarkStormy,
        MarkSnowy,
        MarkBlizzard,
        MarkDry,
        MarkSandstorm,
        MarkMisty,
        MarkDestiny,
        MarkFishing,
        MarkCurry,
        MarkUncommon,
        MarkRare,
        MarkRowdy,
        MarkAbsentMinded,
        MarkJittery,
        MarkExcited,
        MarkCharismatic,
        MarkCalmness,
        MarkIntense,
        MarkZonedOut,
        MarkJoyful,
        MarkAngry,
        MarkSmiley,
        MarkTeary,
        MarkUpbeat,
        MarkPeeved,
        MarkIntellectual,
        MarkFerocious,
        MarkCrafty,
        MarkScowling,
        MarkKindly,
        MarkFlustered,
        MarkPumpedUp,
        MarkZeroEnergy,
        MarkPrideful,
        MarkUnsure,
        MarkHumble,
        MarkThorny,
        MarkVigor,
        MarkSlump,
    }

    public static class RibbonIndexExtensions
    {
        public static bool HasRibbon(this IRibbonIndex x, RibbonIndex r) => x.GetRibbon((int)r);
        public static void SetRibbon(this IRibbonIndex x, RibbonIndex r) => x.SetRibbon((int)r);
    }
}
