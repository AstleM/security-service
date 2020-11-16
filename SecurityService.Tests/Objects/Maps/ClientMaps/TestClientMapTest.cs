using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SecurityService.Objects.Maps.ClientMaps;
using SecurityService.Objects.Entities;
using SecurityService.Objects.DTOs.ClientDtos;
using SecurityService.Objects.DTOs.Client;

namespace SecurityService.Tests.Objects.Maps.ClientMaps
{
    public class TestClientMapTest
    {
        [Fact]
        public void Map_MapsClientToClientGetDto()
        {
            Client client = new Client
            {
                Id = 1,
                Name = "Test"
            };

            ClientGetDto clientGetDto;

            ClientMap clientMap = new ClientMap();

            clientMap.Map(client, out clientGetDto);

            Assert.Equal(1, clientGetDto.Id);
            Assert.Equal("Test", clientGetDto.Name);
        }

        [Fact]
        public void Map_MapsClientGetDtoToClient()
        {
            ClientGetDto clientGetDto = new ClientGetDto
            {
                Name = "Test",
                Id = 1
            };

            Client client;
            ClientMap clientMap = new ClientMap();

            clientMap.Map(clientGetDto, out client);

            Assert.Equal("Test", client.Name);
            Assert.Equal(1, client.Id);
        }

        [Fact]
        public void Map_MapsClientToClientCreateDto()
        {
            Client client = new Client
            {
                Id = 1,
                Name = "Test"
            };

            ClientCreateDto clientCreateDto;
            ClientMap clientMap = new ClientMap();

            clientMap.Map(client, out clientCreateDto);

            Assert.Equal("Test", client.Name);
            Assert.Equal(1, client.Id);
        }

        [Fact]
        public void Map_MapsClientCreateDtoToClient()
        {
            ClientCreateDto clientCreateDto = new ClientCreateDto
            {
                Name = "Test",
                Password = "P@ssw0rd"
            };

            Client client;

            ClientMap clientMap = new ClientMap();

            clientMap.Map(clientCreateDto, out client);

            Assert.Equal("Test", client.Name);
            Assert.Equal(0, client.Id);
        }
    }
}
