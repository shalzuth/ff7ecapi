using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TacticsLevelEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 EffectType { get; set; }
        [Key(2)] public System.Int32 ValueType { get; set; }
        [Key(3)] public System.Int32 ValuePermil { get; set; }
        [Key(4)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
