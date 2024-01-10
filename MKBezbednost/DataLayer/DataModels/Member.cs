using System.ComponentModel.DataAnnotations;

namespace DataLayer.DataModels
{
    public class Member
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        // JMBG - Jedinstveni matični broj građana
        public string? PersonalIdentificationNumber { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Workplace { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public DateOnly? JoinDate { get; set; }
        public DateOnly? RemovalDate { get; set; }
        public byte[]? Image { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
    }
}
