using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboAreaTypeGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 NormalResourceId { get; set; }
        [Key(2)] public System.Int64 SubspeciesResourceId { get; set; }
        [Key(3)] public System.Int64 NormalCharacterNovelSetId { get; set; }
        [Key(4)] public System.Int64 SubspeciesCharacterNovelSetId { get; set; }
    }
}
