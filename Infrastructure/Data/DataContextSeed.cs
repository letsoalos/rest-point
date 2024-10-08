using System.Text.Json;
using Core.Entities;
using Core.Entities._LookUps;

namespace Infrastructure.Data;

public class DataContextSeed
{
    public static async Task SeedAsync(DataContext context)
    {
        if (!context.Addresses.Any())
        {
            var addressData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/address.json");

            var addresses = JsonSerializer.Deserialize<List<Address>>(addressData);

            if (addresses == null) return;

            context.Addresses.AddRange(addresses);

            await context.SaveChangesAsync();
        }

        if (!context.ClientStatuses.Any())
        {
            var clientStatusData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/clientStatus.json");

            var clientStatuses = JsonSerializer.Deserialize<List<ClientStatus>>(clientStatusData);

            if (clientStatuses == null) return;

            context.ClientStatuses.AddRange(clientStatuses);

            await context.SaveChangesAsync();
        }

        if (!context.Discounts.Any())
        {
            var discountData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/discount.json");

            var discounts = JsonSerializer.Deserialize<List<Discount>>(discountData);

            if (discounts == null) return;

            context.Discounts.AddRange(discounts);

            await context.SaveChangesAsync();
        }

        if (!context.DocumentTypes.Any())
        {
            var documenTypeData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/documentType.json");

            var documentTypes = JsonSerializer.Deserialize<List<DocumentType>>(documenTypeData);

            if (documentTypes == null) return;

            context.DocumentTypes.AddRange(documentTypes);

            await context.SaveChangesAsync();
        }

        if (!context.Genders.Any())
        {
            var genderData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/gender.json");

            var genders = JsonSerializer.Deserialize<List<Gender>>(genderData);

            if (genders == null) return;

            context.Genders.AddRange(genders);

            await context.SaveChangesAsync();
        }

        if (!context.Relationships.Any())
        {
            var relationshipsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/relationship.json");

            var relationships = JsonSerializer.Deserialize<List<Relationship>>(relationshipsData);

            if (relationships == null) return;

            context.Relationships.AddRange(relationships);

            await context.SaveChangesAsync();
        }      

        if (!context.PaymentFrequencies.Any())
        {
            var paymentFrequencyData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/paymentFrequency.json");

            var paymentFrequencies = JsonSerializer.Deserialize<List<PaymentFrequency>>(paymentFrequencyData);

            if (paymentFrequencies == null) return;

            context.PaymentFrequencies.AddRange(paymentFrequencies);

            await context.SaveChangesAsync();
        }

        if (!context.PremiumPlans.Any())
        {
            var premiumPlansData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/premiumPlan.json");

            var premiumPlans = JsonSerializer.Deserialize<List<PremiumPlan>>(premiumPlansData);

            if (premiumPlans == null) return;

            context.PremiumPlans.AddRange(premiumPlans);

            await context.SaveChangesAsync();
        }

        if (!context.PaymentMethods.Any())
        {
            var paymentMethodsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/paymentMethod.json");

            var paymentMethods = JsonSerializer.Deserialize<List<PaymentMethod>>(paymentMethodsData);

            if (paymentMethods == null) return;

            context.PaymentMethods.AddRange(paymentMethods);

            await context.SaveChangesAsync();
        }

        if (!context.BurialSocieties.Any())
        {
            var burialSocietiesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/burialSociety.json");

            var burialSocieties = JsonSerializer.Deserialize<List<BurialSociety>>(burialSocietiesData);

            if (burialSocieties == null) return;

            context.BurialSocieties.AddRange(burialSocieties);

            await context.SaveChangesAsync();
        }

        if (!context.ServiceTypes.Any())
        {
            var serviceTypesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/serviceType.json");

            var serviceTypes = JsonSerializer.Deserialize<List<ServiceType>>(serviceTypesData);

            if (serviceTypes == null) return;

            context.ServiceTypes.AddRange(serviceTypes);

            await context.SaveChangesAsync();
        }

        if (!context.Clients.Any())
        {
            var clientsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/client.json");

            var clients = JsonSerializer.Deserialize<List<Client>>(clientsData);

            if (clients == null) return;

            context.Clients.AddRange(clients);

            await context.SaveChangesAsync();
        }

        if (!context.ClientPremia.Any())
        {
            var clientPremiumData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/clientPremium.json");

            var clientPremia = JsonSerializer.Deserialize<List<ClientPremium>>(clientPremiumData);

            if (clientPremia == null) return;

            context.ClientPremia.AddRange(clientPremia);

            await context.SaveChangesAsync();
        }

        if (!context.LateFees.Any())
        {
            var lateFeeData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/lateFee.json");

            var lateFees = JsonSerializer.Deserialize<List<LateFee>>(lateFeeData);

            if (lateFees == null) return;

            context.LateFees.AddRange(lateFees);

            await context.SaveChangesAsync();
        }

        if (!context.FamilyMembers.Any())
        {
            var familyMembersData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/FamilyMember.json");

            var familyMembers = JsonSerializer.Deserialize<List<FamilyMember>>(familyMembersData);

            if (familyMembers == null) return;

            context.FamilyMembers.AddRange(familyMembers);

            await context.SaveChangesAsync();
        }

        if (!context.FuneralServices.Any())
        {
            var funeralServicesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/funeralService.json");

            var funeralServices = JsonSerializer.Deserialize<List<FuneralService>>(funeralServicesData);

            if (funeralServices == null) return;

            context.FuneralServices.AddRange(funeralServices);

            await context.SaveChangesAsync();
        }

        if (!context.PaymentStatuses.Any())
        {
            var paymentStatusesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/paymentStatus.json");

            var paymentStatuses = JsonSerializer.Deserialize<List<PaymentStatus>>(paymentStatusesData);

            if (paymentStatuses == null) return;

            context.PaymentStatuses.AddRange(paymentStatuses);

            await context.SaveChangesAsync();
        }

        if (!context.Payments.Any())
        {
            var paymentsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/payment.json");

            var payments = JsonSerializer.Deserialize<List<Payment>>(paymentsData);

            if (payments == null) return;

            context.Payments.AddRange(payments);

            await context.SaveChangesAsync();
        }

        if (!context.PaymentHistories.Any())
        {
            var paymentHistoriesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/paymentHistory.json");

            var PaymentHistories = JsonSerializer.Deserialize<List<PaymentHistory>>(paymentHistoriesData);

            if (PaymentHistories == null) return;

            context.PaymentHistories.AddRange(PaymentHistories);

            await context.SaveChangesAsync();
        }
    }
}
