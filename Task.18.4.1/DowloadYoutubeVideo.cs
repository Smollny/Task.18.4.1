using System;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task._18._4._1
{
    class DowloadYoutubeVideo
    {
        internal async System.Threading.Tasks.Task StartDowloadYoutubeVideoAsync(string url)
        {
            var youtube = new YoutubeClient();
            await youtube.Videos.DownloadAsync(url, "video.mp4");
            Console.WriteLine("Finishing download...");
        }
    }
}
