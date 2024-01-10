namespace DataLayer.DataModels
{
    public class Gear
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string? Motorcycle { get; set; }
        public bool? Pants { get; set; }
        public bool? OfficialShirt { get; set; }
        public bool? WorkShirt { get; set; }
        public bool? Vest { get; set; }
        public bool? Jacket { get; set; }
        public string? Note { get; set; }
    }
}
