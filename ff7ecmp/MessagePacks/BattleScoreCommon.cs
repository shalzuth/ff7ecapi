using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleScoreCommon
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ScoreBattleRankDeathCountId { get; set; }
        [Key(2)] public System.Int32 TimeBaseSecond { get; set; }
        [Key(3)] public System.Int64 TimeScoreBattleRankCoefficientId { get; set; }
        [Key(4)] public System.Int64 TimeScoreBattleAdditionalScoreGroupId { get; set; }
        [Key(5)] public System.Int64 WeakElementHitCountScoreBattleAdditionalScoreGroupId { get; set; }
        [Key(6)] public System.Int64 NotesBreakCountScoreBattleAdditionalScoreGroupId { get; set; }
    }
}
