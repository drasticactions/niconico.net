using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Tools
{
    public static class EndPoints
    {
        private const string Base = "http://api.ce.nicovideo.jp";

        #region Login

        public const string VitaLogin = "https://account.nicovideo.jp/api/v1/login";

        public const string Login = "https://secure.nicovideo.jp/secure/login?site=niconico";

        #endregion

        #region Session

        public const string CreateSession = Base + "/api/v1/session.create?dummy=1434371749";

        public const string KeepSessionAlive = Base + "/api/v1/session.alive?dummy=1434378670";

        #endregion

        #region User

        public const string UserInfo = Base + "/api/v1/user.info?dummy=1434371749";

        public const string UserPremium = Base + "/api/v1/user.premium?dummy=1434371749";

        #endregion

        #region Genre

        public const string GenreGroup = Base + "/nicoapi/v1/genre.list?dummy=1434379459&group={0}";

        public const string GenreList = Base + "/nicoapi/v1/genre.list?dummy=1434379459";

        #endregion

        #region Video

        public const string VideoRankings =
            Base + "/nicoapi/v1/video.ranking?dummy=1434382202&from={0}&genre={1}&limit={2}&span={3}&type={4}";

        public const string DefVideoList = Base + "/nicoapi/v1/deflist.list?dummy=1434382205&from={0}&limit={1}";

        public const string VideoSherlock = Base + "/nicoapi/v1/video.sherlock?cmd={0}&dummy=1434382205&limit={1}";

        #endregion
    }
}
