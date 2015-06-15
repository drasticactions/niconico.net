using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.User;

namespace NicoNico.Net.Interfaces
{
    public interface IAuthenticationManager
    {
        Task<UserLoginSession> LoginUserThroughV1ApiAsync(string email, string password);

        Task<UserLoginSession> LoginUserAsync(string email, string password);

        CookieContainer CreateLoginCookieContainer(UserLoginSession session);

        Task<UserSession> StartUserSessionAsync();

        Task<UserSession> ExtendUserSessionAsync();
    }
}
