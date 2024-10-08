using Core.Entities._LookUps;

namespace Core.Entities;

public class FuneralService : BaseEntity
{
    public int ClientId { get; set; }
    public DateTime ServiceDate { get; set; }
    public required string Location { get; set; }  
    public int ServiceTypeId { get; set; }  // Burial, Cremation, etc.
    public string? Minister { get; set; }  // Who will be leading the service (optional)
    public string? AdditionalNotes { get; set; }  // Any special requests or details
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy  { get; set; }

    public Client? Client { get; set; }
    public ServiceType? ServiceType { get; set; }  
}
