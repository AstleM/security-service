using SecurityService.Data.Repositories.ClientRepo;
using SecurityService.Data.Services.PasswordService;
using SecurityService.Objects.DTOs.Client;
using SecurityService.Objects.DTOs.ClientDtos;
using SecurityService.Objects.Entities;
using SecurityService.Objects.Maps.ClientMaps;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SecurityService.Data.Services.ClientService
{
    public class TestClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        private readonly IClientMap clientMap;
        private readonly IPasswordService passwordService;

        public TestClientService(IClientRepository clientRepository, IClientMap clientMap, IPasswordService passwordService)
        {
            this.clientRepository = clientRepository;
            this.clientMap = clientMap;
            this.passwordService = passwordService;
        }

        public ClientGetDto Create(ClientCreateDto clientToCreate)
        {
            byte[] salt = passwordService.GenerateSalt(32);
            byte[] hash = passwordService.GenerateHash(clientToCreate.Password, salt, 12, 32);
            clientToCreate.Password = null;
            Client client = clientRepository.Create(clientToCreate, hash, salt);
            ClientGetDto output;
            clientMap.Map(client, out output);
            return output;
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
