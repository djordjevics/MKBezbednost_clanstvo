namespace DataLayer.DataModels;

public class Training
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public DateOnly Date { get; set; }
    public required string Level { get; set; }
    public bool IssuedCertificate { get; set; }
    public string? City { get; set; }
    public int? Price { get; set; }
    public string? Note { get; set; }
}
