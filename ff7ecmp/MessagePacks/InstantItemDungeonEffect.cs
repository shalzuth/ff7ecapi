using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class InstantItemDungeonEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Priority { get; set; }
        [Key(2)] public System.Int32 EffectType { get; set; }
        [Key(3)] public System.Int32 GrantValueType { get; set; }
        [Key(4)] public System.Int32 EffectValue { get; set; }
        [Key(5)] public System.Int32 TriggerType { get; set; }
    }
}
