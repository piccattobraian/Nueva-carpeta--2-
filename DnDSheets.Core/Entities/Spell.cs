using DnDSheets.Core.Rules;

namespace DnDSheets.Core.Entities;

public class Spell
{
    public int Id { get; set; }
    public RuleSet RuleSet { get; set; }
    public string Name { get; set; } = "";
    public int Level { get; set; }
    public string School { get; set; } = "";
    public string Description { get; set; } = "";
    public string Source { get; set; } = "SRD";
}