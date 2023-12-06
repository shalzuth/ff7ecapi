using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPassiveEffectGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int32 PassiveSkillType { get; set; }
        [Key(3)] public System.Int32 PassiveSkillDetailType { get; set; }
        [Key(4)] public System.Int64 PassiveSkillEffectLevelId { get; set; }
    }
}
