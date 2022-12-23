using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDuplicate.Api.Data;
using BlazorDuplicate.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDuplicate.Api.Repositories;

public class ClientPersonRepository
{
    private readonly DataContext context;

    public ClientPersonRepository(DataContext context)
    {
        this.context = context;
    }

    public async Task<List<ClientPerson>> GetItemsAsync()
    {
        var clientPersons = await context.ClientPersons.ToListAsync();
        return clientPersons;
    }

    public async Task<ClientPerson?> GetItemAsync(int id)
    {
        var clientPerson = await context.ClientPersons.FindAsync(id);
        return clientPerson;
    }
}
