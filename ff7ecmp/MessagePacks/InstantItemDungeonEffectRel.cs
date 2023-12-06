using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class InstantItemDungeonEffectRel
    {
        [Key(0)] public System.Int64 InstantItemDungeonId { get; set; }
        [Key(1)] public System.Int64 InstantItemDungeonEffectId { get; set; }
    }
}
