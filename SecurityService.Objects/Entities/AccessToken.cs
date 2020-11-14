using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SecurityService.Objects.Entities
{
    public class AccessToken
    {
        public byte[] Token { get; set; }
        public DateTimeOffset TokenCreatedTime { get; set; }
        public DateTimeOffset TokenExperationTime { get; set; }
        public bool IsActive { get; set; }
    }
}
