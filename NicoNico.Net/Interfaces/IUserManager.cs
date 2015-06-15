using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.User;

namespace NicoNico.Net.Interfaces
{
    public interface IUserManager
    {
        Task<User> GetCurrentUserInfoAsync();

        Task GetCurrentUserPremiumInfoAsync(User user);
    }
}
