using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ResistDamage
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TriggerCoefficient { get; set; }
        [Key(2)] public System.Int32 CriticalDamageCoefficient { get; set; }
        [Key(3)] public System.Int32 PhysicalDamageCoefficient { get; set; }
        [Key(4)] public System.Int32 MagicalDamageCoefficient { get; set; }
    }
}
