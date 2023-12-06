using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillReinforcementEffectEnemy
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 EnemyId { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Int64 MaxRewardCount { get; set; }
    }
}
