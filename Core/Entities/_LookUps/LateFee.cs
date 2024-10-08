namespace Core.Entities._LookUps;

public class LateFee : BaseEntity
{
    public int ClientPremiumId { get; set; }
    public decimal Amount { get; set; }
    public DateTime AppliedDate { get; set; }
    public required string Description { get; set; }

    public ClientPremium? ClientPremium { get; set; }
}
