using Core.Entities._LookUps;

namespace Core.Entities;

public class Payment : BaseEntity
{
    public int ClientPremiumId { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal AmountPaid { get; set; }
    public int PaymentMethodId { get; set; } // e.g., Credit Card, Bank Transfer
    public string? TransactionId { get; set; } // Used for tracking
    public int PaymentStatusId { get; set; } // e.g., Pending, Completed, Failed
    public required string InvoiceNumber { get; set; }
    public DateTime NextPaymentDueDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy  { get; set; }

    public required ClientPremium ClientPremium { get; set; }
    public required PaymentMethod PaymentMethod { get; set; }
    public required PaymentStatus PaymentStatus { get; set; }

}
