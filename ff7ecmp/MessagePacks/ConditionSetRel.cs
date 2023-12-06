using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ConditionSetRel
    {
        [Key(0)] public System.Int64 ConditionSetId { get; set; }
        [Key(1)] public System.Int64 ConditionId { get; set; }
    }
}
