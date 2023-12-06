using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleFieldEffectGroupRel
    {
        [Key(0)] public System.Int64 BattleFieldEffectGroupId { get; set; }
        [Key(1)] public System.Int64 BattleFieldEffectId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
