using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MissionPlayRecord
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 PlayRecordType { get; set; }
    }
}
