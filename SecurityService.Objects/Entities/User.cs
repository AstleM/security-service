using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Objects.Entities
{
    /// <summary>
    /// An entity for the users who are stored in the API. Each user belongs to a Client
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string UserName { get; set; }
    }
}
