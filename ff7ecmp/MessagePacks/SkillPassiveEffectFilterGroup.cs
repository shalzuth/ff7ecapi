using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPassiveEffectFilterGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int32 PassiveSkillFilterType { get; set; }
        [Key(3)] public System.Int32 FilterValue { get; set; }
    }
}
