namespace API.Dtos;

public class ClientDto
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? IdentityNumber { get; set; }
    public string? Passport { get; set; }
    public required string PhoneNumber { get; set; }
    public string? Email { get; set; }    
    public required string EmergencyContactName { get; set; }
    public required string EmergencyContactPhoneNumber { get; set; }
    public bool Consent { get; set; }
    public required string ClientReferenceNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy  { get; set; }
    public required string Address { get; set; }
    public required string Gender { get; set; }
    public required string DocumentType { get; set; }
    public required string ClientStatus { get; set; }
    public string? BurialSociety { get; set; }

}
