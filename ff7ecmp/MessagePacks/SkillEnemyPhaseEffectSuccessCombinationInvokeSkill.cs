using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEnemyPhaseEffectSuccessCombinationInvokeSkill
    {
        [Key(0)] public System.Int64 SkillEnemyPhaseEffectSuccessCombinationGroupId { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 InvokeSkillEnemyId { get; set; }
        [Key(3)] public System.Int32 OverrideIdx { get; set; }
    }
}
