using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class InstantItemDungeon
    {
        [Key(0)] public System.Int64 InstantItemId { get; set; }
        [Key(1)] public System.Int32 TargetType { get; set; }
        [Key(2)] public System.Int32 ItemDungeonDisplayType { get; set; }
    }
}
