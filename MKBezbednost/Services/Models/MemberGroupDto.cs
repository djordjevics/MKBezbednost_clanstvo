using Services.Enums;
using System.Drawing;

namespace Services.Models;

public class MemberGroupDto
{
    public MemberGroupType Type { get; set; }
    public required string DisplayName {get; set; }
    public required Color Color { get; set; }
    public required bool MembershipObligation { get; set; }
}
