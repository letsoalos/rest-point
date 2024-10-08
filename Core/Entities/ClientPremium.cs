using Core.Entities;
using Core.Entities._LookUps;

public class ClientPremium : BaseEntity
{
    public int ClientId { get; set; }
    public int PremiumPlanId { get; set; }  
    public decimal TotalAmountPaid { get; set; }
    public DateTime StartDate { get; set; }
    public int PaymentFrequencyId { get; set; }
    public int? BurialSocietyId { get; set; } 
    public bool IsActive { get; set; }

    public Client? Client { get; set; }
    public PremiumPlan? PremiumPlan { get; set; } 
    public PaymentFrequency? PaymentFrequency { get; set; }  
    public BurialSociety? BurialSociety { get; set; }
}
