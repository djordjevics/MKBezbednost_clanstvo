﻿namespace DataLayer.DataModels;

public class MemberCard
{
    public int Id { get; set; }
    public required int MemberId { get; set; }
    // broj kartice
    public required string MemberCardId { get; set; }
    public required DateOnly IssueDate { get; set; }
    public bool? GivenToMember { get; set; }

}