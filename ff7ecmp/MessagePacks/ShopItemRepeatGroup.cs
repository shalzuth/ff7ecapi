using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ShopItemRepeatGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
