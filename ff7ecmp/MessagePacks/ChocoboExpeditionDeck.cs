using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboExpeditionDeck
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 OrderNo { get; set; }
        [Key(2)] public System.Int32 DeckType { get; set; }
        [Key(3)] public System.Int32 ConsumptionStone { get; set; }
        [Key(4)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(5)] public System.Int64 LockConditionSetId { get; set; }
    }
}
