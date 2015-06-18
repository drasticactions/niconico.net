using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Managers;

namespace NicoNico.Net.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Enter Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Enter Password: ");

            // Mask Password
            var pass = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key != ConsoleKey.Backspace || pass.Length <= 0) continue;
                    pass = pass.Substring(0, (pass.Length - 1));
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);

            var authManager = new AuthenticationManager();
            var userLoginSession = await authManager.LoginUserThroughV1ApiAsync(email, pass);
            var cookieContainer = authManager.CreateLoginCookieContainer(userLoginSession);

            // Reset the authentication manager with the proper cookie container.
            authManager = new AuthenticationManager(cookieContainer);
            var session = await authManager.StartUserSessionAsync();

            // In order to test "extending" the users session, we need to reset the authManager again,
            // this time with the session key.
            authManager = new AuthenticationManager(cookieContainer, session.Session);

            var test = await authManager.ExtendUserSessionAsync();

            //var genreManager = new GenreManager(cookieContainer, session.Session);
            //var test3 = await genreManager.GetGenreListAsync();
            //var test4 = await genreManager.GetGenreGroupsAsync();

            var liveVideoManager = new LiveVideoManager(cookieContainer, session.Session);
            var test10 = await liveVideoManager.GetComingSoonListAsync();
            var test11 = await liveVideoManager.GetOnAirListAsync();

            var videoManager = new VideoManager(cookieContainer, session.Session);
            //var test5 = await videoManager.GetDefListAsync(0, 10);
            //var test2 = await videoManager.GetVideoInfoAsync(new string[] { "sm26238346", "sm9" });
            //var test8 = await videoManager.GetVideoFlvAsync("sm26238346");
            //var test6 = await videoManager.GetVideoInfoAsync("sm26238346");
            //var thumbManager = new ThumbManager(cookieContainer, session.Session);
            //var test7 = await thumbManager.GetThumbInfoAsync("sm26156154");

            var userManager = new UserManager(cookieContainer, session.Session);
            var user = await userManager.GetCurrentUserInfoAsync();
            await userManager.GetCurrentUserPremiumInfoAsync(user.User);

            Console.WriteLine("");
            Console.WriteLine("Nickname: " + user.User.Nickname);
            Console.WriteLine("Country: " + user.User.Country);
            Console.WriteLine("Prefecture: " + user.User.Prefecture);
            Console.WriteLine("Sex: " + user.User.Sex);
            Console.WriteLine("Thumbnail: " + user.User.ThumbnailUrl);
            Console.WriteLine("Push any key to exit");
            Console.ReadKey();
        }
    }
}
