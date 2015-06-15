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

        public async Task<User> GetCurrentUserInfoAsync()
        {
            var result = await _webManager.GetData(new Uri(EndPoints.UserInfo));
            if (!result.IsSuccess)
            {
                throw new Exception("Failed to Get User Info: " + result.ResultXml);
            }

            try
            {
                var xmlUserObject = result.ResultXml.ParseXml<nicovideo_user_response>();
                var vitaOption = new VitaOption();
                if (xmlUserObject.vita_option != null)
                {
                    vitaOption.SimpleRegisterProfile = xmlUserObject.vita_option.simple_register_profile;
                    vitaOption.UserSecret = xmlUserObject.vita_option.user_secret;
                }

                return new User()
                {
                    Id = xmlUserObject.user.id,
                    MobileMail = xmlUserObject.user.mobile_mail,
                    Nickname = xmlUserObject.user.nickname,
                    Prefecture = xmlUserObject.user.prefecture,
                    Birthday = xmlUserObject.user.birthday,
                    Sex = xmlUserObject.user.sex,
                    Country = xmlUserObject.user.country,
                    Language = xmlUserObject.user.language,
                    CreateTime = xmlUserObject.user.create_time,
                    UpdateTime = xmlUserObject.user.update_time,
                    ThumbnailUrl = xmlUserObject.user.thumbnail_url,
                    VitaOption = vitaOption
                };
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
                var xmlUserObject = result.ResultXml.ParseXml<nicovideo_user_response>();
                var premium = new Premium()
                {
                    ExpireTime = xmlUserObject.expire_time,
                    Purchaseable = xmlUserObject.purchasable,
                    IsPremium = xmlUserObject.premium
                };
                user.Premium = premium;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Login: " + result.ResultXml, ex);
            }
        }
    }
}
