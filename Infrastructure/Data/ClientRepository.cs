using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ClientRepository(DataContext context) : IClientRepository
{
    public void AddClient(Client client)
    {
        context.Clients.Add(client);
    }

    public bool ClientExists(int id)
    {
        return context.Clients.Any(x => x.Id == id);
    }

    public void DeleteClient(Client client)
    {
        context.Clients.Remove(client);
    }

    public async Task<Client?> GetClientByIdAsync(int id)
    {
        return await context.Clients.FindAsync(id);
    }

    public async Task<IReadOnlyList<Client>> GetClientsAsync()
    {
        return await context.Clients.ToListAsync();
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public void UpdateClient(Client client)
    {
        context.Entry(client).State = EntityState.Modified;
    }
}
