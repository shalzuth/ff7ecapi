using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CharacterStory
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 CharacterId { get; set; }
        [Key(2)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(3)] public System.Int64 LockConditionSetId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
    }
}
