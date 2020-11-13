using System;
using System.Collections.Generic;
using System.Text;
using SecurityService.Objects.DTOs.ClientDtos;
using SecurityService.Objects.Entities;

namespace SecurityService.Data.Repositories.ClientRepo
{
    public interface IClientRepository
    {
        Client Get(int clientId);
        Client Create(ClientCreateDto clientToCreate, byte[] passwordHash, byte[] passwordSalt);
    }
}
