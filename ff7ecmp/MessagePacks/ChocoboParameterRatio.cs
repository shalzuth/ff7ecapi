using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboParameterRatio
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SpeedWeight { get; set; }
        [Key(2)] public System.Int32 StaminaWeight { get; set; }
        [Key(3)] public System.Int32 IntelligenceWeight { get; set; }
        [Key(4)] public System.Int32 AdaptabilityWeight { get; set; }
    }
}
