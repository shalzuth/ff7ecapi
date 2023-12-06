using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ScoreBattleRankBase
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 DeathCountScoreBattleRankId { get; set; }
        [Key(2)] public System.Int64 MaxBlowDamageScoreBattleRankId { get; set; }
        [Key(3)] public System.Int64 TakenDamageScoreBattleRankId { get; set; }
        [Key(4)] public System.Int64 TimeScoreBattleRankId { get; set; }
    }
}
