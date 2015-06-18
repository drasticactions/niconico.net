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

        public const string UserCurrentInfo = Base + "/api/v1/user.info?dummy=1434371749";

        public const string UserInfo = Base + "/api/v1/user.info?dummy=1434463727&user_id={0}";

        public const string UserPremium = Base + "/api/v1/user.premium?dummy=1434371749";

        #endregion

        #region Genre

        public const string GenreGroup = Base + "/nicoapi/v1/genre.list?dummy=1434379459&group={0}";

        public const string GenreList = Base + "/nicoapi/v1/genre.list?dummy=1434379459";

        public const string GenreRecent =
            Base +
            "/nicoapi/v1/genre.recent?dummy=1434457736&from={0}&genre={1}&limit={2}";

        #endregion

        #region Video

        public const string VideoRankings =
            Base + "/nicoapi/v1/video.ranking?dummy=1434382202&from={0}&genre={1}&limit={2}&span={3}&type={4}";

        public const string DefVideoList = Base + "/nicoapi/v1/deflist.list?dummy=1434382205&from={0}&limit={1}";

        public const string VideoSherlock = Base + "/nicoapi/v1/video.sherlock?cmd={0}&dummy=1434382205&limit={1}";

        public const string VideoInfo =
            Base + "/nicoapi/v1/video.info?dummy=1434458035&v={0}";

        public const string VideoRelation =
            Base + "/nicoapi/v1/video.relation?dummy=1434458035&from={0}&limit={1}&order={2}&sort={3}&v={4}";

        public const string VideoPlay = Base + "/nicoapi/v1/video.play?dummy=1434458036&v={0}";

        public const string VideoArray = Base + "/nicoapi/v1/video.array?dummy=1434461473&v={0}";

        public const string OnAirList =
            Base + "/liveapi/v1/video.onairlist?from={0}&limit={1}&order={2}&pt={3}&sort={4}&__format=json";

        public const string ComingSoon =
           Base + "/liveapi/v1/video.comingsoon?from={0}&limit={1}&pt={2}&__format=json";

        #endregion

        public const string MyListGroup = Base + "/nicoapi/v1/mylistgroup.get?dummy=1434461475";

        public const string ThumbInfo = "http://ext.nicovideo.jp/api/getthumbinfo/{0}";

        public const string VideoFlv = "http://flapi.nicovideo.jp/api/getflv?device={0}&eco={1}&v={2}";

        public const string SearchSuggestion = "http://search.nicovideo.jp/suggestion/complete/";

        public const string Message = "http://msg.nicovideo.jp/{2}/api.json/thread?version=20090904&thread={0}&res_from={1}";
    }
}
