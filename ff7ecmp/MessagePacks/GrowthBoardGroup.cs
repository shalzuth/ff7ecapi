using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GrowthBoardGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 TargetId { get; set; }
        [Key(2)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(3)] public System.Int32 GrowthBoardType { get; set; }
        [Key(4)] public System.Int64 BoardDesignTemplateId { get; set; }
    }
}
