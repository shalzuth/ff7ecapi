using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEnemyPhaseEffectTutorial
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TutorialStepType { get; set; }
        [Key(2)] public System.Int32 PhaseTutorialTimingType { get; set; }
    }
}
