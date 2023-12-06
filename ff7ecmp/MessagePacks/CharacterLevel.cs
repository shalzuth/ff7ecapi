using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CharacterLevel
    {
        [Key(0)] public System.Int64 CharacterId { get; set; }
        [Key(1)] public System.Int64 Level { get; set; }
        [Key(2)] public System.Int64 Exp { get; set; }
        [Key(3)] public System.Int32 Hp { get; set; }
        [Key(4)] public System.Int32 PhysicalAttack { get; set; }
        [Key(5)] public System.Int32 MagicalAttack { get; set; }
        [Key(6)] public System.Int32 PhysicalDefense { get; set; }
        [Key(7)] public System.Int32 MagicalDefense { get; set; }
        [Key(8)] public System.Int32 HealingPower { get; set; }
    }
}
