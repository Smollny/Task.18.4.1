using System;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task._18._4._1
{
    class Receiver
    {
        public async System.Threading.Tasks.Task Operation(string url)
        {
            var youtube = new YoutubeClient();
            Console.WriteLine("Starting download...");
            await youtube.Videos.DownloadAsync(url, "video.mp4");
            Console.WriteLine("Finishing download...");
        }
    }
}
