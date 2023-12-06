using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ScoreOption
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 OptionType { get; set; }
        [Key(2)] public System.Int64 TargetId { get; set; }
    }
}
