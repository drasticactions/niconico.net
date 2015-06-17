using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.User;
using NicoNico.Net.Entities.Web;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IWebManager _webManager;

        public UserManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public UserManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }

        public async Task<UserEntity> GetCurrentUserInfoAsync()
        {
            var result = await _webManager.GetData(new Uri(EndPoints.UserCurrentInfo));
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to Get User Info: " + result.ResultXml);
            }

            try
            {
                return result.ResultXml.ParseXml<UserEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Login: " + result.ResultXml, ex);
            }
        }

        public async Task GetCurrentUserPremiumInfoAsync(User user)
        {
            var result = await _webManager.GetData(new Uri(EndPoints.UserPremium));
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to Get User Premium Info: " + result.ResultXml);
            }

            try
            {
                var xmlUserObject = result.ResultXml.ParseXml<Premium>();
                user.Premium = xmlUserObject;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Login: " + result.ResultXml, ex);
            }
        }
    }
}
