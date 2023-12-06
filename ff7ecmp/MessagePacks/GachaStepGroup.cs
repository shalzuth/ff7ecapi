using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStepGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaId { get; set; }
        [Key(2)] public System.Int32 MaxCount { get; set; }
        [Key(3)] public System.Int32 Priority { get; set; }
        [Key(4)] public System.Int64 ResetId { get; set; }
        [Key(5)] public System.Boolean IsStampProgress { get; set; }
    }
}
