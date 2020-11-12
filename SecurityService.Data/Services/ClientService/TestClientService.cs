using SecurityService.Data.Repositories.ClientRepo;
using SecurityService.Objects.DTOs.Client;
using SecurityService.Objects.Entities;
using SecurityService.Objects.Maps.ClientMaps;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Data.Services.ClientService
{
    public class TestClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        private readonly IClientMap clientMap;

        public TestClientService(IClientRepository clientRepository, IClientMap clientMap)
        {
            this.clientRepository = clientRepository;
            this.clientMap = clientMap;
        }

        public ClientGetDto Get(int clientId)
        {
            Client client = clientRepository.Get(clientId);
            ClientGetDto output;
            clientMap.Map(client, out output);
            return output;
        }
    }
}
