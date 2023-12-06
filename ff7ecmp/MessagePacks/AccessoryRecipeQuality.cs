using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AccessoryRecipeQuality
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 AccessoryRecipeId { get; set; }
        [Key(2)] public System.Int32 QualityType { get; set; }
        [Key(3)] public System.Int64 AccessoryDurationGroupId { get; set; }
        [Key(4)] public System.Int64 AccessoryPassivePointGroupId { get; set; }
        [Key(5)] public System.Int32 CraftBasePassivePoint { get; set; }
    }
}
