using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoGachaWishTargetProbability
    {
        [Key(0)] public System.Int64 GachaId { get; set; }
        [Key(1)] public System.Int64 GachaWeaponLotSetId { get; set; }
        [Key(2)] public System.Int32 GachaLotType { get; set; }
        [Key(3)] public System.Int64 ProbabilityPpb { get; set; }
        [Key(4)] public System.String DisplayProbabilityStr { get; set; }
    }
}
