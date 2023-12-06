using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ScoreOptionCharacter
    {
        [Key(0)] public System.Int64 ScoreOptionCharacterGroupId { get; set; }
        [Key(1)] public System.Int64 CharacterId { get; set; }
    }
}
