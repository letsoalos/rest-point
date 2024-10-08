using System.ComponentModel.DataAnnotations;
using Core.Entities._LookUps;

namespace Core.Entities;

public class Client : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int DocumentTypeId { get; set; }
    public string? IdentityNumber { get; set; }
    public string? Passport { get; set; }
    public int GenderId { get; set; }
    [Phone]
    public required string PhoneNumber { get; set; }
    [EmailAddress]
    public string? Email { get; set; }    
    public required string EmergencyContactName { get; set; }
    public required string EmergencyContactPhoneNumber { get; set; }
    public int ClientStatusId { get; set; }
    public int? BurialSocietyId { get; set; }
    public bool Consent { get; set; }
    public required string ClientReferenceNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }

    public int AddressId { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy  { get; set; }

    public Address? Address { get; set; }
    public Gender? Gender { get; set; }
    public DocumentType? DocumentType { get; set; }
    public ClientStatus? ClientStatus { get; set; } 
    public BurialSociety? BurialSociety { get; set; }
}
