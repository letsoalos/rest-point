using System.ComponentModel.DataAnnotations;
using Core.Entities._LookUps;

namespace Core.Entities;

public class FamilyMember : BaseEntity
{
    public int ClientId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int GenderId { get; set; }
    public int RelationshipId { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Phone]
    public string? PhoneNumber { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public bool IsBeneficiary { get; set; }
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy { get; set; }

    public required Client Client { get; set; }
    public required Relationship Relationship { get; set; }
    public required Gender Gender { get; set; }
}
