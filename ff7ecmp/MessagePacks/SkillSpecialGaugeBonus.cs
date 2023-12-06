using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillSpecialGaugeBonus
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 GaugeBonusType { get; set; }
        [Key(2)] public System.Int32 GaugeUp { get; set; }
    }
}
