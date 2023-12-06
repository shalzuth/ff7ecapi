using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillResistChangeEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ResistDamageId { get; set; }
        [Key(2)] public System.Int64 ResistElementId { get; set; }
        [Key(3)] public System.Int64 ResistBuffDebuffId { get; set; }
        [Key(4)] public System.Int64 ResistStatusConditionId { get; set; }
        [Key(5)] public System.Boolean ResetOnInterrupt { get; set; }
    }
}
