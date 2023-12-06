using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetGroupRel
    {
        [Key(0)] public System.Int64 GachaStampSheetGroupId { get; set; }
        [Key(1)] public System.Int64 Seq { get; set; }
        [Key(2)] public System.Int64 GachaStampSheetId { get; set; }
        [Key(3)] public System.Int64 NextSeq { get; set; }
    }
}
