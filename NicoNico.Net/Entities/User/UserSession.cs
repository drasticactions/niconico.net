using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.User
{
    public class UserSession
    {
        public uint Id { get; set; }

        public string Status { get; set; }

        public string Session { get; set; }
    }
}
