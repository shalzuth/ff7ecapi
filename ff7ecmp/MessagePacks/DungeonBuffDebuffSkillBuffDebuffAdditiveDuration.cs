using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffSkillBuffDebuffAdditiveDuration
    {
        [Key(0)] public System.Int64 DungeonBuffDebuffId { get; set; }
        [Key(1)] public System.Int32 SkillBuffDebuffType { get; set; }
    }
}
