using SecurityService.Objects.DTOs.ClientDtos;
using SecurityService.Objects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Data.Repositories.ClientRepo
{
    public class TestClientRepo : IClientRepository
    {
        public Client Create(ClientCreateDto clientToCreate, byte[] passwordHash, byte[] passwordSalt)
        {
            return new Client
            {
                Id = 1,
                Name = clientToCreate.Name
            };
        }

        public Client Get(int clientId)
        {
            return new Client
            {
                Id = clientId,
                Name = "TestClient"
            };
        }
    }
}
