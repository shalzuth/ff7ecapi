using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillTriggerConditionHp
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 MinPermil { get; set; }
        [Key(2)] public System.Int32 MaxPermil { get; set; }
    }
}
