using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillSpecialGaugeCost
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Cost { get; set; }
        [Key(2)] public System.Int32 CostGaugeUp { get; set; }
    }
}
