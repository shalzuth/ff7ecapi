using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Setting
    {
        [Key(0)] public System.Int32 SettingType { get; set; }
        [Key(1)] public System.String DefaultValue { get; set; }
    }
}
