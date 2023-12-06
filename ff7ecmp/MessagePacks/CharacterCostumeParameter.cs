using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CharacterCostumeParameter
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 HpCoefficient { get; set; }
        [Key(2)] public System.Int32 PhysicalAttackCoefficient { get; set; }
        [Key(3)] public System.Int32 MagicalAttackCoefficient { get; set; }
        [Key(4)] public System.Int32 PhysicalDefenseCoefficient { get; set; }
        [Key(5)] public System.Int32 MagicalDefenseCoefficient { get; set; }
        [Key(6)] public System.Int32 HealingPowerCoefficient { get; set; }
    }
}
