namespace Core.Entities._LookUps;

public class ClientStatus : BaseEntity
{ 
    public required string Name { get; set; }  // e.g., "Active", "Suspended", "Terminated"
    public required string Description { get; set; }  // Optional description of what the status represents
    public bool IsActive { get; set; }  // Flag to indicate if the status is currently in use

}
