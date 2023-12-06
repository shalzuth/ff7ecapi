using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ResistElement
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ElementType { get; set; }
        [Key(2)] public System.Int32 DamageCoefficient { get; set; }
    }
}
