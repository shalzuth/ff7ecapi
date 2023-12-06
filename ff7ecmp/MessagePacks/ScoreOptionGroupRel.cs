using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ScoreOptionGroupRel
    {
        [Key(0)] public System.Int64 ScoreOptionGroupId { get; set; }
        [Key(1)] public System.Int64 ScoreOptionId { get; set; }
        [Key(2)] public System.Int32 Idx { get; set; }
    }
}
