using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ResistBuffDebuff
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 BuffDebuffType { get; set; }
        [Key(2)] public System.Int32 TriggerCoefficient { get; set; }
        [Key(3)] public System.Int32 Duration { get; set; }
        [Key(4)] public System.Int32 AdditionalDuration { get; set; }
    }
}
