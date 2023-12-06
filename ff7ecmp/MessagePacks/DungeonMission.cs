using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonMission
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 DungeonMissionType { get; set; }
        [Key(2)] public System.Int64 TargetId { get; set; }
        [Key(3)] public System.Int64 TargetValue { get; set; }
        [Key(4)] public System.Int32 TargetElementType { get; set; }
        [Key(5)] public System.Int64 RewardSetId { get; set; }
        [Key(6)] public System.Int64 NameLanguageId { get; set; }
        [Key(7)] public System.Boolean IsHide { get; set; }
    }
}
