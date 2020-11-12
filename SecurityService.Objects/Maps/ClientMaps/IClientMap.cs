using SecurityService.Objects.DTOs.Client;
using SecurityService.Objects.DTOs.ClientDtos;
using SecurityService.Objects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Objects.Maps.ClientMaps
{
    public interface IClientMap
    {
        void Map(Client client, out ClientGetDto output);
        void Map(Client client, out ClientCreateDto output);
        void Map(ClientGetDto clientGetDto, out Client output);
        void Map(ClientCreateDto clientCreateDto, out Client output);
    }
}
