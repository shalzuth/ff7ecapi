using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaDurationLot
    {
        [Key(0)] public System.Int64 MateriaDurationGroupId { get; set; }
        [Key(1)] public System.Int32 DurationMinMinute { get; set; }
        [Key(2)] public System.Int32 DurationMaxMinute { get; set; }
    }
}
