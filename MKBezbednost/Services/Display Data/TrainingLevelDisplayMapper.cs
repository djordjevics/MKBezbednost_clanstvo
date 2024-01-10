using Services.Enums;

namespace Services.DisplayData;

static class TrainingLevelNameMapper
{
    // For now name of levels and display names are the same, so additional collection is not needed.
    //private static readonly List<TrainingLevelDisplay> Collection =
    //[
    //    new TrainingLevelDisplay()
    //    {
    //        Level = TrainingLevel.Osnovni,
    //        DisplayName = "Osnovni"
    //    },
    //    new TrainingLevelDisplay()
    //    {
    //        Level = TrainingLevel.Napredni,
    //        DisplayName = "Napredni"
    //    },
    //    new TrainingLevelDisplay()
    //    {
    //        Level = TrainingLevel.Offroad,
    //        DisplayName = "Offroad"
    //    }
    //];

    public static string MapFrom(TrainingLevel t)
    {
        return nameof(t);
    }
}
