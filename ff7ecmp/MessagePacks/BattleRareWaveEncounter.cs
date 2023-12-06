using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleRareWaveEncounter
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 BattleRareWaveSetId { get; set; }
        [Key(2)] public System.Int64 EventBaseId { get; set; }
        [Key(3)] public System.Int64 ConditionSetId { get; set; }
    }
}
