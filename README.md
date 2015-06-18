# niconico.net
## A C# Library for accessing NicoNico Douga

[Nuget Package](https://www.nuget.org/packages/NicoNico.Net)

[Nicovideo](http://nicovideo.jp) is a Japanese video sharing website, similar to Youtube. Users can upload, watch, and comment on videos; both recorded and broadcast live. They don't have a public API _persay_; Parts of it are [public](http://search.nicovideo.jp/docs/api/contest.html), other parts are not. Some exclusivly use XML, others only JSON, and others give query string options to flip between them. There is a Vita specific API set that is now used on a variety of platforms, such as Wii U and Windows, despite it still having vita specific namespaces and functions.

This library is an attempt to abstract away the insane nature of their API and create a clean library (well, as clean as it can be) that can enable anyone to just get started and make an NicoNico app. 

### Getting Started

NicoNico.net is a Profile 111 PCL. It _should_ just work in most projects, including WinRT, Xamarin.iOS and Xamarin.Android, and .Net 4.5+. Currently the only dependency is Json.Net.

You can download the Nuget version of the package [here](https://www.nuget.org/packages/NicoNico.Net)

You can also go to your Nuget package manager of choice and search for "niconico.net".

### Logging In

In order to make authenticated calls against their system, you must log in. Makes sense right? Logging in is complex however. Unlike most newer APIs the use an OAUTH Rest based system, NicoNico is partially cookie, partially session key based. For the Vita sections of the API, a session key must be appended to the request in order to finish the transaction. So we need to make a few API calls to get all the information we need.

```cs
// Login Through Vita API
var authManager = new AuthenticationManager();
var userLoginSession = await authManager.LoginUserThroughV1ApiAsync("email address", "password");
var cookieContainer = authManager.CreateLoginCookieContainer(userLoginSession);

// Reset the authentication manager with the proper cookie container.
authManager = new AuthenticationManager(cookieContainer);
var session = await authManager.StartUserSessionAsync();
```

userLoginSession contains the user id, session key, and expire time for that session key. We give that to CreateLoginCookieContainer to create the cookie container we will use to make requests with. We then reinitialize the Authentication manager with the cookie container, so now it can use our login credentials. After all that, we can call StartUserSessionAsync to get our actual user session token.

Now you should be logged in.

### Getting a Video
Once you have cookies and session key, you are ready to start looking for videos.

```cs
var videoManager = new VideoManager(cookieContainer, session.Session);
var watchedList = await videoManager.GetDefListAsync(0, 10);
var videoInfo = watchedList.VideoInfoList.FirstOrDefault();
if (videoInfo != null)
{
  var videoPlay = await videoManager.GetVideoFlvAsync(videoInfo.Video.Id);
  var messages = await videoManager.GetVideoMessageEntityAsync(videoInfo.Thread.Id.ToString(), videoPlay.ApiChannel);
  Console.WriteLine(videoPlay.Url);
}
```

Here we instantiate the Video Manager with the cookies and session key we got from the above commands. We then get the first 10 recently watched videos, select the first one from the list, and using the videos ID we can get the streaming video URL.

Calling GetVideoMessageEntityAsync lets us get the comments that users have put on top of the video, as well as where they are located. ApiChannel is needed so we know which Nico server to access to retreve them.

### TODO

- Finish mapping currently known API functions
- Better seperate each part of the API, so users know which apis were accessed from where (Vita, Android, iOS, Web)
- And probably more I can't think of.
