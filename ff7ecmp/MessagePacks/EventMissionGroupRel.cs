using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventMissionGroupRel
    {
        [Key(0)] public System.Int64 EventBaseId { get; set; }
        [Key(1)] public System.Int64 MissionGroupId { get; set; }
    }
}
