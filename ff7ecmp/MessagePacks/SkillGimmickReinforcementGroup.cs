using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickReinforcementGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 SkillBaseId { get; set; }
    }
}
