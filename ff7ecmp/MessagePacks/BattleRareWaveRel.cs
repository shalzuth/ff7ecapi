using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleRareWaveRel
    {
        [Key(0)] public System.Int64 BattleRareWaveSetId { get; set; }
        [Key(1)] public System.Int64 BattleId { get; set; }
        [Key(2)] public System.Int64 BattleRareWaveGroupId { get; set; }
    }
}
