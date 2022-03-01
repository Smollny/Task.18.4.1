using System;
using YoutubeExplode;

namespace Task._18._4._1
{
    class GetInfoYoutubeVideo
    {
        public async System.Threading.Tasks.Task GetInfoYoutubeVideoAsync(string url)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(url);
            Console.WriteLine(video.Title);
            Console.WriteLine(video.Description);
        }
    }
}
