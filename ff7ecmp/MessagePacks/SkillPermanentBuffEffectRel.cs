using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPermanentBuffEffectRel
    {
        [Key(0)] public System.Int64 SkillPermanentBuffEffectId { get; set; }
        [Key(1)] public System.Int32 PermanentBuffType { get; set; }
        [Key(2)] public System.Int64 SkillUpDetailId { get; set; }
    }
}
