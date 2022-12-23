using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDuplicate.Api.Models;
using BlazorDuplicate.Api.Repositories;

namespace BlazorDuplicate.Api.Services
{
    public class ClientPersonService
    {
        private readonly ClientPersonRepository clientPersonRepository;

        public ClientPersonService(ClientPersonRepository clientPersonRepository)
        {
            this.clientPersonRepository = clientPersonRepository;
        }

        public async Task<List<ClientPerson>> GetAllClientPersons()
        {
            var clientPersons = await clientPersonRepository.GetItemsAsync();
            return clientPersons;
        }

        public async Task<ClientPerson?> GetClientPerson(int id)
        {
            var clientPerson = await clientPersonRepository.GetItemAsync(id);
            return clientPerson;
        }
    }
}
