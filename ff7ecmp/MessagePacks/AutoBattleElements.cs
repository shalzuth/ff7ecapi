using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoBattleElements
    {
        [Key(0)] public System.Int64 BattleId { get; set; }
        [Key(1)] public System.Int32 ElementType { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
