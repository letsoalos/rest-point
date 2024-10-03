namespace Core.Entities._LookUps;

public class PremiumPlan : BaseEntity
{
    public required string Name { get; set; }  // Name of the plan (e.g., "Gold Plan")
    public required string Description { get; set; }  // Details of what the plan covers
    public decimal Amount { get; set; }  // Monthly/Yearly premium price
    public decimal CoverageAmount { get; set; }  // Coverage amount offered by the plan
    public bool IsActive { get; set; }  // Indicates if the plan is currently available
    public DateTime CreatedDate { get; set; }
}
