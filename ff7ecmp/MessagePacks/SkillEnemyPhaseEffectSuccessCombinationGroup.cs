using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEnemyPhaseEffectSuccessCombinationGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillNameLanguageId { get; set; }
        [Key(2)] public System.Int32 PhaseActionControlType { get; set; }
        [Key(3)] public System.Boolean IsHideSkillName { get; set; }
        [Key(4)] public System.Int32 OverridePositioningLayoutType { get; set; }
    }
}
