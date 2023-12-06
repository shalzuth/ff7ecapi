using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetCellRel
    {
        [Key(0)] public System.Int64 GachaStampSheetId { get; set; }
        [Key(1)] public System.Int64 StampCount { get; set; }
        [Key(2)] public System.Int64 GachaStampSheetCellId { get; set; }
    }
}
