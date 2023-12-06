using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemSeasonPass
    {
        [Key(0)] public System.Int64 ItemId { get; set; }
        [Key(1)] public System.Int64 SeasonPassId { get; set; }
    }
}
