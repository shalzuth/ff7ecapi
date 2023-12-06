using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoSkillPassiveUsedType
    {
        [Key(0)] public System.Int32 PassiveSkillUsedType { get; set; }
        [Key(1)] public System.Int64 PassiveSkillId { get; set; }
    }
}
