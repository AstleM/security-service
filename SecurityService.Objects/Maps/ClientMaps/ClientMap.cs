using SecurityService.Objects.DTOs.Client;
using SecurityService.Objects.DTOs.ClientDtos;
using SecurityService.Objects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Objects.Maps.ClientMaps
{
    public class ClientMap : IClientMap
    {
        public void Map(Client client, out ClientGetDto output)
        {
            output = new ClientGetDto
            {
                Id = client.Id,
                Name = client.Name
            };
        }

        public void Map(Client client, out ClientCreateDto output)
        {
            output = new ClientCreateDto
            {
                Name = client.Name,
            };
        }

        public void Map(ClientGetDto clientGetDto, out Client output)
        {
            output = new Client
            {
                Id = clientGetDto.Id,
                Name = clientGetDto.Name
            };
        }

        public void Map(ClientCreateDto clientCreateDto, out Client output)
        {
            output = new Client
            {
                Name = clientCreateDto.Name
            };
        }
    }
}
