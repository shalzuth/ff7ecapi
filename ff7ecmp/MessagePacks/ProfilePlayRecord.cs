using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ProfilePlayRecord
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 PlayRecordType { get; set; }
        [Key(2)] public System.Int64 NameLanguageId { get; set; }
        [Key(3)] public System.Int64 OrderNo { get; set; }
        [Key(4)] public System.Int64 ProfilePlayRecordGroupId { get; set; }
    }
}
