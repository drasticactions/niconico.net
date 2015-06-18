using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.User;
using NicoNico.Net.Entities.Web;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IWebManager _webManager;

        public AuthenticationManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public AuthenticationManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }

        public async Task<UserLoginSession> LoginUserThroughV1ApiAsync(string email, string password)
        {
            var body = new StringContent(string.Format(Constants.LoginForm, email, password), Encoding.UTF8, "application/x-www-form-urlencoded");
            var result = await _webManager.PostData(new Uri(EndPoints.VitaLogin), null, body);
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to Login: " + result.ResultXml);
            }

            try
            {
                var user = result.ResultXml.ParseXml<UserLoginSession>();
                if (user.UserId <= 0)
                {
                    throw new Exception("Failed to Login: " + result.ResultXml);
                }
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Login: " + result.ResultXml, ex);
            }
        }

        public async Task<UserLoginSession> LoginUserAsync(string email, string password)
        {
            var body = new StringContent(string.Format(Constants.LoginForm, email, password), Encoding.UTF8, "application/x-www-form-urlencoded");
            var result = await _webManager.PostData(new Uri(EndPoints.Login), null, body);
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to Login: " + result.ResultXml);
            }

            try
            {
                var user = result.ResultXml.ParseXml<UserLoginSession>();
                if (user.UserId <= 0)
                {
                    throw new Exception("Failed to Login: " + result.ResultXml);
                }
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Login: " + result.ResultXml, ex);
            }
        }

        public CookieContainer CreateLoginCookieContainer(UserLoginSession session)
        {
            var container = new CookieContainer();
            var cookie = new Cookie("user_session", session.SessionKey, "/", "nicovideo.jp");
            container.Add(new Uri("http://api.ce.nicovideo.jp"), cookie);
            return container;
        }

        public async Task<UserSession> StartUserSessionAsync()
        {
            if (!_webManager.IsCookieContainerSet)
            {
                throw new Exception("You must log the user in and set the cookie container");
            }

            var result = await _webManager.GetData(new Uri(EndPoints.CreateSession));
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to Create Session: " + result.ResultXml);
            }

            try
            {
                return result.ResultXml.ParseXml<UserSession>();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Create Session: " + result.ResultXml, ex);
            }
        }

        public async Task<UserSession> ExtendUserSessionAsync()
        {
            if (!_webManager.IsCookieContainerSet)
            {
                throw new Exception("You must log the user in and set the cookie container");
            }

            if (!_webManager.IsSessionKeySet)
            {
                throw new Exception("You must set the session key in order to extend the users session");
            }

            var result = await _webManager.GetData(new Uri(EndPoints.KeepSessionAlive));
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to extend Session: " + result.ResultXml);
            }

            try
            {
                return result.ResultXml.ParseXml<UserSession>();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to extend Session: " + result.ResultXml, ex);
            }
        }
    }
}
