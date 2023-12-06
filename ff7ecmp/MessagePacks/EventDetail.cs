using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventDetail
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ResorceId { get; set; }
        [Key(2)] public System.Int64 DisplayRewardSetId { get; set; }
        [Key(3)] public System.Int64 GachaId1 { get; set; }
        [Key(4)] public System.Int64 GachaId2 { get; set; }
        [Key(5)] public System.Int64 CautionLanguageId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
