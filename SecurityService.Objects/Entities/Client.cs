using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SecurityService.Objects.Entities
{
    /// <summary>
    /// An entitiy for the callers of the API
    /// </summary>
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
