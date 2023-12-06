using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEnemyPhaseEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillEnemyPhaseEffectSuccessGroupId { get; set; }
        [Key(2)] public System.Int64 SkillEnemyPhaseJoinIndexGroupId { get; set; }
        [Key(3)] public System.Int32 PhaseGimmickType { get; set; }
        [Key(4)] public System.Int64 SkillGimmickId0 { get; set; }
        [Key(5)] public System.Int64 SkillGimmickId1 { get; set; }
        [Key(6)] public System.Int64 SkillGimmickId2 { get; set; }
        [Key(7)] public System.Int32 DurationSec { get; set; }
        [Key(8)] public System.Int64 EnemyBreakId { get; set; }
        [Key(9)] public System.Int64 ResourceId { get; set; }
        [Key(10)] public System.Boolean IgnoreTransitionFlag { get; set; }
        [Key(11)] public System.Boolean DisableLockOtherSkill { get; set; }
        [Key(12)] public System.Int64 SkillNotesSetGroupSeriesId0 { get; set; }
        [Key(13)] public System.Int64 SkillNotesSetGroupSeriesId1 { get; set; }
        [Key(14)] public System.Int64 SkillNotesSetGroupSeriesId2 { get; set; }
        [Key(15)] public System.Boolean DisableActionSkill { get; set; }
        [Key(16)] public System.Int64 SkillEnemyPhaseEffectHelpId { get; set; }
        [Key(17)] public System.Int64 SkillEnemyPhaseEffectTutorialId { get; set; }
        [Key(18)] public System.Int32 OverrideAiEvalDamageBoolType { get; set; }
        [Key(19)] public System.Int64 SkillNotesGuardGroupId0 { get; set; }
        [Key(20)] public System.Int64 SkillNotesGuardGroupId1 { get; set; }
        [Key(21)] public System.Int64 SkillNotesGuardGroupId2 { get; set; }
    }
}
