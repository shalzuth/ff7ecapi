using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TacticsLevel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 TacticsId { get; set; }
        [Key(2)] public System.Int32 Level { get; set; }
        [Key(3)] public System.Int32 LevelUpSecond { get; set; }
        [Key(4)] public System.Int64 NormalTacticsLevelEffectGroupId { get; set; }
        [Key(5)] public System.Int64 MatchTacticsLevelEffectGroupId { get; set; }
    }
}
