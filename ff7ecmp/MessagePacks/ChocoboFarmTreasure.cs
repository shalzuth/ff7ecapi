using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboFarmTreasure
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ChocoboFarmTermId { get; set; }
        [Key(2)] public System.Int32 Seq { get; set; }
        [Key(3)] public System.Int64 RewardSetId { get; set; }
        [Key(4)] public System.Int64 ResourceId { get; set; }
        [Key(5)] public System.Int64 PlaceId { get; set; }
    }
}
