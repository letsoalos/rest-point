using Core.Entities._LookUps;

namespace Core.Entities;

public class PaymentHistory : BaseEntity
{
    public required int ClientId { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal TotalAmountPaid { get; set; }
    public int PaymentMethodId { get; set; }
    public required string ReferenceNumber { get; set; }
    public string? Description { get; set; }
    public int PaymentStatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy  { get; set; }

    public required Client Client { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }
    public required PaymentStatus PaymentStatus { get; set; }
}
