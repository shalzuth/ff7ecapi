using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetDirectionLot
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaStampSheetDirectionLotGroupId { get; set; }
        [Key(2)] public System.Int32 ProgressCount { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
    }
}
