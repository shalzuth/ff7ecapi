using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventDramaSelectionChoice
    {
        [Key(0)] public System.Int64 EventDramaSelectionId { get; set; }
        [Key(1)] public System.Int64 Idx { get; set; }
        [Key(2)] public System.Int64 LockConditionSetId { get; set; }
        [Key(3)] public System.Int64 ChoiceLanguageId { get; set; }
    }
}
