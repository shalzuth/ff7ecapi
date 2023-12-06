using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MissionSet
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MissionGroupId { get; set; }
    }
}
