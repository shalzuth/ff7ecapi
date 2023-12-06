using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleScoreSettingDetail
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ParameterHpCoefficient { get; set; }
        [Key(2)] public System.Int32 ParameterPhysicalAttackCoefficient { get; set; }
        [Key(3)] public System.Int32 ParameterMagicalAttackCoefficient { get; set; }
        [Key(4)] public System.Int32 ParameterPhysicalDefenseCoefficient { get; set; }
        [Key(5)] public System.Int32 ParameterMagicalDefenseCoefficient { get; set; }
        [Key(6)] public System.Int32 ParameterHealingPowerCoefficient { get; set; }
        [Key(7)] public System.Int32 ParameterCriticalRateCoefficient { get; set; }
        [Key(8)] public System.Int32 ParameterCriticalPowerCoefficient { get; set; }
        [Key(9)] public System.Int32 SkillScoreCalculateType { get; set; }
        [Key(10)] public System.Int32 SkillScorePhysicalDamageCoefficient { get; set; }
        [Key(11)] public System.Int32 SkillScoreMagicalDamageCoefficient { get; set; }
        [Key(12)] public System.Int32 SkillScoreHealCoefficient { get; set; }
        [Key(13)] public System.Int32 SkillScoreDamageRateCoefficient { get; set; }
        [Key(14)] public System.Int32 SkillScoreHealRateCoefficient { get; set; }
        [Key(15)] public System.Int32 BuffPhysicalAttackUpCoefficient { get; set; }
        [Key(16)] public System.Int32 BuffPhysicalDefenseUpCoefficient { get; set; }
        [Key(17)] public System.Int32 BuffMagicalAttackUpCoefficient { get; set; }
        [Key(18)] public System.Int32 BuffMagicalDefenseUpCoefficient { get; set; }
        [Key(19)] public System.Int32 BuffPhysicalAttackDownCoefficient { get; set; }
        [Key(20)] public System.Int32 BuffPhysicalDefenseDownCoefficient { get; set; }
        [Key(21)] public System.Int32 BuffMagicalAttackDownCoefficient { get; set; }
        [Key(22)] public System.Int32 BuffMagicalDefenseDownCoefficient { get; set; }
        [Key(23)] public System.Int32 BuffHealingPowerUpCoefficient { get; set; }
        [Key(24)] public System.Int32 BuffHealingPowerDownCoefficient { get; set; }
        [Key(25)] public System.Int32 BuffElementResistanceUpCoefficient { get; set; }
        [Key(26)] public System.Int32 BuffElementResistanceDownCoefficient { get; set; }
        [Key(27)] public System.Int32 SkillStatusConditionPoisonCoefficient { get; set; }
        [Key(28)] public System.Int32 SkillStatusConditionSadnessCoefficient { get; set; }
        [Key(29)] public System.Int32 SkillStatusConditionSilenceCoefficient { get; set; }
        [Key(30)] public System.Int32 SkillStatusConditionDarknessCoefficient { get; set; }
        [Key(31)] public System.Int32 SkillStatusConditionStunCoefficient { get; set; }
        [Key(32)] public System.Int32 SkillStatusConditionPainCoefficient { get; set; }
        [Key(33)] public System.Int32 SkillStatusConditionForgetCoefficient { get; set; }
        [Key(34)] public System.Int32 BuffTimeCoefficient { get; set; }
        [Key(35)] public System.Int32 DebuffTimeCoefficient { get; set; }
        [Key(36)] public System.Int32 ConditionTimeCoefficient { get; set; }
        [Key(37)] public System.Int32 ResurrectionCoefficient { get; set; }
        [Key(38)] public System.Int32 RegenerateCoefficient { get; set; }
        [Key(39)] public System.Int32 SpecialSkillBaseValue { get; set; }
    }
}
