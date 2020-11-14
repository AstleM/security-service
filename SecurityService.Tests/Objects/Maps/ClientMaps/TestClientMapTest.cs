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

            ClientGetDto expectedOutcome = new ClientGetDto
            {
                Id = 1,
                Name = "Test"
            };

            TestClientMap testClientMap = new TestClientMap();

            testClientMap.Map(client, out clientGetDto);

            Assert.Equal(expectedOutcome, clientGetDto);
        }
    }
}
