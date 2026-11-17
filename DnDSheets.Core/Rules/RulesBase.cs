using DnDSheets.Core.Entities;

namespace DnDSheets.Core.Rules;

public abstract class RulesBase : IRulesEngine
{
    public abstract RuleSet RuleSet { get; }
    public abstract string SpeciesLabel { get; }
    public abstract string AbilityBonusSource { get; }
    public abstract bool HasWeaponMastery { get; }
    public abstract IReadOnlyList<string> CreationSteps { get; }

    public virtual int AbilityModifier(int score) =>
        (int)Math.Floor((score - 10) / 2.0);

    public virtual int ProficiencyBonus(int level) =>
        2 + (Math.Clamp(level, 1, 20) - 1) / 4;

    public virtual int SavingThrow(Character c, Ability ability)
    {
        var bonus = AbilityModifier(c.GetScore(ability));
        if (c.SavingThrowProficiencies.Contains(ability.ToString()))
            bonus += ProficiencyBonus(c.Level);
        return bonus;
    }

    public virtual int SkillBonus(Character c, SkillInfo skill)
    {
        var bonus = AbilityModifier(c.GetScore(skill.Ability));
        if (c.SkillProficiencies.Contains(skill.Key))
            bonus += ProficiencyBonus(c.Level);
        return bonus;
    }

    public virtual int Initiative(Character c) => AbilityModifier(c.Dexterity);

    public virtual int PassivePerception(Character c) =>
        10 + SkillBonus(c, SkillCatalog.Get("Perception"));
}