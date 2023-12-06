using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ResourceId { get; set; }
        [Key(2)] public System.Int64 LanguageId { get; set; }
    }
}
