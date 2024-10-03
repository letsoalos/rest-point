using Core.Entities;
using Core.Entities._LookUps;

public class ClientPremium : BaseEntity
{
    public int ClientId { get; set; }
    public int PremiumPlanId { get; set; }  
    public decimal TotalAmountPaid { get; set; }
    public DateTime StartDate { get; set; }
    public int PaymentFrequencyId { get; set; }
    public bool IsActive { get; set; }

    public required Client Client { get; set; }
    public required PremiumPlan PremiumPlan { get; set; } 
    public required PaymentFrequency PaymentFrequency { get; set; }  
}
