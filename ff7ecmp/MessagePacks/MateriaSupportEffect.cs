using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaSupportEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaSupportEffectGroupId { get; set; }
        [Key(2)] public System.Int32 SupportEffectType { get; set; }
        [Key(3)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(4)] public System.Int32 SupportEffectTriggerType { get; set; }
        [Key(5)] public System.Int64 MateriaSupportEffectFilterGroupId { get; set; }
    }
}
