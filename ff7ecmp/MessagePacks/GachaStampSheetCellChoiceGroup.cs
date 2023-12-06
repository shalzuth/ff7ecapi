using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetCellChoiceGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaStampSheetGroupId { get; set; }
        [Key(2)] public System.Int64 GachaStampSheetSeq { get; set; }
        [Key(3)] public System.Int64 StampCount { get; set; }
        [Key(4)] public System.Int64 DefaultGachaStampSheetCellChoiceId { get; set; }
    }
}
