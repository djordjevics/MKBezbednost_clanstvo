using Services.Enums;

namespace Services.Models;

public class TrainingLevelDisplay
{
    public TrainingLevel Level { get; set; }
    public required string DisplayName { get; set; }
}
