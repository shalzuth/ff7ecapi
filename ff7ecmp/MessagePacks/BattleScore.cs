using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleScore
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MaxBlowDamageScoreBattleRankCoefficientId { get; set; }
        [Key(2)] public System.Int64 MaxBlowDamageScoreBattleAdditionalScoreGroupId { get; set; }
        [Key(3)] public System.Int64 TakenDamageScoreBattleRankCoefficientId { get; set; }
        [Key(4)] public System.Int64 TakenDamageScoreBattleAdditionalScoreGroupId { get; set; }
    }
}
