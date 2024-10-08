using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ClientsController(IClientRepository repo, IMapper mapper) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ClientDto>>> GetClients()
    {
        var clients = await repo.GetClientsAsync();

        return Ok(mapper.Map<IReadOnlyList<ClientDto>>(clients));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ClientDto>> GetClient(int id)
    {
        var client = await repo.GetClientByIdAsync(id);

        if (client == null) return NotFound();

        return mapper.Map<Client, ClientDto>(client);
    }

    [HttpPost]
    public async Task<ActionResult<Client>> CreateClient(Client client)
    {
        repo.AddClient(client);

        if (await repo.SaveChangesAsync())
        {
            return CreatedAtAction("GetClient", new {id = client.Id}, client);
        }

        return BadRequest("Problem adding client");
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateClient(int id, Client client)
    {
        if (client.Id != id || !ClientExists(id)) return BadRequest($"Client with ID {id} no longer exists");

        repo.UpdateClient(client);

        if (await repo.SaveChangesAsync())
        {
            return NoContent();
        }

        return BadRequest("Problem updating the client");
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteClient(int id)
    {
        var client = await repo.GetClientByIdAsync(id);

        if (client == null) return NotFound();

        repo.DeleteClient(client);

        if (await repo.SaveChangesAsync())
        {
            return NoContent();
        }

        return BadRequest("Problem deleting the client");
    }


    private bool ClientExists(int id)
    {
        return repo.ClientExists(id);
    }
}
