using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Battle
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ResourceId { get; set; }
        [Key(2)] public System.Int64 WaveGroupId { get; set; }
        [Key(3)] public System.Boolean CanContinue { get; set; }
        [Key(4)] public System.Int32 ContinuableCount { get; set; }
        [Key(5)] public System.Int64 ContinueLimitSec { get; set; }
        [Key(6)] public System.Int64 BattleLimitSec { get; set; }
        [Key(7)] public System.Boolean IsHideRecommendedElement { get; set; }
        [Key(8)] public System.Int64 RecommendedElementsSetId { get; set; }
        [Key(9)] public System.Boolean IsHideRecommendedNote { get; set; }
        [Key(10)] public System.Int64 RecommendedNotesSetId { get; set; }
        [Key(11)] public System.Boolean IsHideRecommendedCombatPower { get; set; }
        [Key(12)] public System.Int64 RecommendedCombatPower { get; set; }
        [Key(13)] public System.Int32 CharacterExp { get; set; }
        [Key(14)] public System.Int32 UserExp { get; set; }
        [Key(15)] public System.Int64 EnvironmentResource { get; set; }
        [Key(16)] public System.Int64 AreaIndex { get; set; }
        [Key(17)] public System.Boolean IgnoreResultBgm { get; set; }
        [Key(18)] public System.Int64 BattleScoreId { get; set; }
        [Key(19)] public System.Int64 BattleScoreCommonId { get; set; }
        [Key(20)] public System.String BgmCueName { get; set; }
        [Key(21)] public System.Int64 BattleFieldEffectGroupId { get; set; }
    }
}
