using System.Reflection;
using Core.Entities;
using Core.Entities._LookUps;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientPremium> ClientPremia { get; set; }
    public DbSet<FamilyMember> FamilyMembers { get; set; }
    public DbSet<FuneralService> FuneralServices { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<PaymentHistory> PaymentHistories { get; set; }
    public DbSet<ClientStatus> ClientStatuses { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<LateFee> LateFees { get; set; }
    public DbSet<PremiumPlan> PremiumPlans { get; set; }
    public DbSet<Relationship> Relationships { get; set; }
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<PaymentStatus> PaymentStatuses { get; set; }
    public DbSet<PaymentFrequency> PaymentFrequencies { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
