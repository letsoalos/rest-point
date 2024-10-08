namespace Core.Entities;

public class BurialSociety : BaseEntity
{
    public required string Name { get; set; }
    public string? ContactPerson { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}
