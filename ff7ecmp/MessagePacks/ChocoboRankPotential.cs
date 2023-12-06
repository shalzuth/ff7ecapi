using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboRankPotential
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 InitialRankType { get; set; }
        [Key(2)] public System.Int32 LimitRankType { get; set; }
    }
}
