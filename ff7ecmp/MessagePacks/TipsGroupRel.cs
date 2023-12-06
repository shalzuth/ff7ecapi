using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TipsGroupRel
    {
        [Key(0)] public System.Int64 TipsGroupId { get; set; }
        [Key(1)] public System.Int64 TipsId { get; set; }
    }
}
