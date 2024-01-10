namespace DataLayer.DataModels;

public class MemberNote
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public DateOnly Date { get; set; }
    public required string Text { get; set; }
}
