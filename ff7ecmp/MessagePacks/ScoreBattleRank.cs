using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ScoreBattleRank
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 RankSScoreValue { get; set; }
        [Key(2)] public System.Int32 RankAScoreValue { get; set; }
        [Key(3)] public System.Int32 RankBScoreValue { get; set; }
        [Key(4)] public System.Int32 RankCScoreValue { get; set; }
        [Key(5)] public System.Int32 RankDScoreValue { get; set; }
        [Key(6)] public System.Int32 RankEScoreValue { get; set; }
        [Key(7)] public System.Int32 RankFScoreValue { get; set; }
    }
}
