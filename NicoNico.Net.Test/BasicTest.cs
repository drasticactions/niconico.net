using System;
using Xunit;
using NicoNico.Net.Managers;
using System.Threading.Tasks;
using System.Net;
using NicoNico.Net.Entities.User;

namespace NicoNico.Net.Test
{
    public class BasicTest
    {
        Managers.AuthenticationManager authManager;
        CookieContainer cookieContainer;
        UserSession session;

        public BasicTest ()
        {
            var email = Environment.GetEnvironmentVariable("NICO_EMAIL");
            var password = Environment.GetEnvironmentVariable("NICO_PASSWORD");

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new Exception("You need to add a test email and password to your environment variables!");

            Setup(email, password);
        }

        private void Setup (string email, string password)
        {
            authManager = new Managers.AuthenticationManager();
            var userLoginSession = authManager.LoginUserThroughV1ApiAsync(email, password).Result;
            cookieContainer = authManager.CreateLoginCookieContainer(userLoginSession);

            // Reset the authentication manager with the proper cookie container.
            authManager = new Managers.AuthenticationManager(cookieContainer);
            session = authManager.StartUserSessionAsync().Result;
        }

        [Fact]
        public async void ExtendingSession()
        {
            session = await authManager.StartUserSessionAsync();

            Assert.NotNull(session);
            Assert.NotNull(session.Session);

            // In order to test "extending" the users session, we need to reset the authManager again,
            // this time with the session key.
            authManager = new Managers.AuthenticationManager(cookieContainer, session.Session);

            var newSession = await authManager.ExtendUserSessionAsync();
            Assert.NotNull(newSession);
            Assert.Equal("normal",  newSession.Status);
        }

        [Fact]
        public async void Search_GetSuggestions()
        {
            var searchManager = new SearchManager(cookieContainer, session.Session);
            var suggestion = await searchManager.GetSuggestions("実況");
            Assert.True(suggestion.Candidates.Length > 0);
        }

        [Fact]
        public async void Genre()
        {
            var genreManager = new GenreManager(cookieContainer, session.Session);
            var test3 = await genreManager.GetGenreListAsync();
            Assert.NotNull(test3);
            var test4 = await genreManager.GetGenreGroupsAsync();
            Assert.NotNull(test4);
        }

        [Fact]
        public async void Live()
        {
            var liveVideoManager = new LiveVideoManager(cookieContainer, session.Session);
            var test10 = await liveVideoManager.GetComingSoonListAsync();
            Assert.NotNull(test10);
            var test11 = await liveVideoManager.GetOnAirListAsync();
            Assert.NotNull(test11);
        }

        [Fact]
        public async void Video()
        {
            var videoManager = new VideoManager(cookieContainer, session.Session);
            var test5 = await videoManager.GetDefListAsync(0, 10);
            Assert.NotNull(test5);
            var test2 = await videoManager.GetVideoInfoAsync(new string[] { "sm26238346", "sm9" });
            Assert.NotNull(test2);
            var test8 = await videoManager.GetVideoFlvAsync("sm26238346");
            Assert.NotNull(test8);
            var test6 = await videoManager.GetVideoInfoAsync("sm26238346");
            Assert.NotNull(test6);
        }

        [Fact]
        public async void User()
        {
            var userManager = new UserManager(cookieContainer, session.Session);
            var user = await userManager.GetCurrentUserInfoAsync();
            await userManager.GetCurrentUserPremiumInfoAsync(user.User);

            Assert.NotNull(user);

            Console.WriteLine("Nickname: " + user.User.Nickname);
            Console.WriteLine("Country: " + user.User.Country);
            Console.WriteLine("Prefecture: " + user.User.Prefecture);
            Console.WriteLine("Sex: " + user.User.Sex);
            Console.WriteLine("Thumbnail: " + user.User.ThumbnailUrl);
        }
    }
}
