using SecurityService.Objects.DTOs.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Data.Services.ClientService
{
    public interface IClientService
    {
        ClientGetDto Get(int clientId);
    }
}
