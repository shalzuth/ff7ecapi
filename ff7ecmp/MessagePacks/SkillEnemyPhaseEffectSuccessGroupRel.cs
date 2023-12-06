using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEnemyPhaseEffectSuccessGroupRel
    {
        [Key(0)] public System.Int64 SkillEnemyPhaseEffectSuccessGroupId { get; set; }
        [Key(1)] public System.Int64 SkillEnemyPhaseEffectSuccessCombinationGroupId { get; set; }
    }
}
