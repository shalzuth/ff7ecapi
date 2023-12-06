using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TacticsLevelEffectGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 TacticsLevelEffectId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
