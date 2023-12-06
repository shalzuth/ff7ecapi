using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaSupportEffectFilterGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int32 SupportEffectFilterType { get; set; }
        [Key(3)] public System.Int64 Value { get; set; }
    }
}
