using Services.Models;
using Services.Enums;
using System.Drawing;

namespace Services.DisplayData;

public static class MemberGroupDisplay
{
    private static readonly List<MemberGroupDto> Collection =
    [
        new MemberGroupDto()
        {
            Type = MemberGroupType.Uprava,
            DisplayName = "Uprava",
            Color = Color.LightCyan,
            MembershipObligation = true
        },
        new MemberGroupDto()
        {
            Type = MemberGroupType.Redovni,
            DisplayName = "Redovni Član",
            Color = Color.LightGreen,
            MembershipObligation = true
        },
        new MemberGroupDto()
        {
            Type = MemberGroupType.DecaPrijatelji,
            DisplayName = "Deca i prijatelji",
            Color = Color.LightYellow,
            MembershipObligation = false
        },
        new MemberGroupDto()
        {
            Type = MemberGroupType.Pocasni,
            DisplayName = "Počasni Član",
            Color = Color.RebeccaPurple,
            MembershipObligation = false
        }
    ];

    public static MemberGroupDto MapFrom(MemberGroupType type)
    {
        return Collection.First(member => member.Type == type);
    }
}
