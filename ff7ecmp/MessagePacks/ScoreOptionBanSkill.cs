using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ScoreOptionBanSkill
    {
        [Key(0)] public System.Int64 ScoreOptionBanSkillGroupId { get; set; }
        [Key(1)] public System.Int32 SkillType { get; set; }
    }
}
