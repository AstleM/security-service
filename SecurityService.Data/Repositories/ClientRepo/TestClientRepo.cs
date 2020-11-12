using SecurityService.Objects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Data.Repositories.ClientRepo
{
    public class TestClientRepo : IClientRepository
    {
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
