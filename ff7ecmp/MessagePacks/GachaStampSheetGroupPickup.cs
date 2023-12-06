using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetGroupPickup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaStampSheetGroupId { get; set; }
        [Key(2)] public System.Int32 GachaStampSheetCellType { get; set; }
        [Key(3)] public System.Int32 GachaFixedLotType { get; set; }
        [Key(4)] public System.Int64 RewardId { get; set; }
        [Key(5)] public System.Int32 OrderNo { get; set; }
    }
}
