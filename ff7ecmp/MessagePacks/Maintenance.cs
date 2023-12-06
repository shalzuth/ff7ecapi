using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Maintenance
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MaintenanceApiGroupId { get; set; }
        [Key(2)] public System.Int32 MaintenanceType { get; set; }
        [Key(3)] public System.Int32 TargetPlatformType { get; set; }
        [Key(4)] public System.String OfficialTwitterUrl { get; set; }
        [Key(5)] public System.Int64 StartDatetime { get; set; }
        [Key(6)] public System.Int64 EndDatetime { get; set; }
        [Key(7)] public System.Int64 TitleLanguageId { get; set; }
        [Key(8)] public System.Int64 DescriptionTemplateLanguageId { get; set; }
        [Key(9)] public System.String CenterUrl { get; set; }
    }
}
