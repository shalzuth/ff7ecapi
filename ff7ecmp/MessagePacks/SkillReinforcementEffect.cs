using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillReinforcementEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillReinforcementEffectGroupId { get; set; }
    }
}
