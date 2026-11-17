using System.ComponentModel.DataAnnotations;
using DnDSheets.Core.Rules;

namespace DnDSheets.Core.Entities;

public class Character
{
    public int Id { get; set; }
    public string OwnerId { get; set; } = default!;
    public RuleSet RuleSet { get; set; } = RuleSet.DnD2014;

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(80)]
    public string Name { get; set; } = "";

    public string ClassName { get; set; } = "";
    public string Subclass { get; set; } = "";
    public string Species { get; set; } = "";     // Raza (2014) / Especie (2024)
    public string Background { get; set; } = "";
    public string Alignment { get; set; } = "";
    public int Level { get; set; } = 1;

    public int Strength { get; set; } = 10;
    public int Dexterity { get; set; } = 10;
    public int Constitution { get; set; } = 10;
    public int Intelligence { get; set; } = 10;
    public int Wisdom { get; set; } = 10;
    public int Charisma { get; set; } = 10;

    public int MaxHp { get; set; } = 10;
    public int CurrentHp { get; set; } = 10;
    public int ArmorClass { get; set; } = 10;
    public int Speed { get; set; } = 30;

    // Se guardan las claves: "Strength", "Dexterity"... y "Athletics", "Stealth"...
    public List<string> SavingThrowProficiencies { get; set; } = new();
    public List<string> SkillProficiencies { get; set; } = new();

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int GetScore(Ability ability) => ability switch
    {
        Ability.Strength => Strength,
        Ability.Dexterity => Dexterity,
        Ability.Constitution => Constitution,
        Ability.Intelligence => Intelligence,
        Ability.Wisdom => Wisdom,
        Ability.Charisma => Charisma,
        _ => 10
    };
}