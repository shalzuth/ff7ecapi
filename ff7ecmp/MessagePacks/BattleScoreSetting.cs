using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleScoreSetting
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ComparisonThresholdCoefficient { get; set; }
        [Key(2)] public System.Int32 AverageCoefficient { get; set; }
        [Key(3)] public System.Int64 BattleScoreSettingDetailId { get; set; }
        [Key(4)] public System.Int64 EnemyBattleScoreSettingDetailId { get; set; }
        [Key(5)] public System.Int64 BattleScoreComparisonSettingId { get; set; }
    }
}
