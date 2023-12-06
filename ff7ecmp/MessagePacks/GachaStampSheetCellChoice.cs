using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetCellChoice
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 GachaStampSheetCellChoiceType { get; set; }
        [Key(2)] public System.Int64 GachaStampSheetCellChoiceGroupId { get; set; }
        [Key(3)] public System.Int64 RewardSetId { get; set; }
    }
}
