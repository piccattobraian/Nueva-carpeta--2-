namespace DnDSheets.Core.Rules;

public class Rules2014 : RulesBase
{
    public override RuleSet RuleSet => RuleSet.DnD2014;
    public override string SpeciesLabel => "Raza";
    public override string AbilityBonusSource => "Raza";
    public override bool HasWeaponMastery => false;
    public override IReadOnlyList<string> CreationSteps =>
        new[] { "Raza", "Clase", "Atributos", "Trasfondo", "Equipo" };
}