namespace DataLayer.DataModels
{
    public class AuditLog
    {
        public int Id { get; set; }
        public required DateTime Timestamp { get; set; }
        public required string Log { get; set; }
    }
}
