namespace DataLayer.DataModels
{
    public class Membership
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public required int Amount { get; set; }
        public required DateOnly PaymentDate { get; set; }
        public string? PaymentType { get; set; }
        public string? Note { get; set; }
    }
}
