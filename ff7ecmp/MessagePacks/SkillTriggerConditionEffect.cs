using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillTriggerConditionEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 BuffDebuffGroupId { get; set; }
        [Key(2)] public System.Int64 StatusConditionGroupId { get; set; }
        [Key(3)] public System.Int32 BuffDebuffMinLevel { get; set; }
        [Key(4)] public System.Int32 BuffDebuffMaxLevel { get; set; }
    }
}
