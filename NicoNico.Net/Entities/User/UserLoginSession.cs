using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.User
{
    public class UserLoginSession
    {
        public uint UserId { get; set; }

        public string SessionKey { get; set; }

        public string Expire { get; set; }
    }
}
