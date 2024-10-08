using Core.Entities;

namespace Core.Interfaces;

public interface IClientRepository
{
    Task<IReadOnlyList<Client>> GetClientsAsync();
    Task<Client?> GetClientByIdAsync(int id);
    void AddClient(Client client);
    void UpdateClient(Client client);
    void DeleteClient(Client client);
    bool ClientExists(int id);
    Task<bool> SaveChangesAsync();
}
