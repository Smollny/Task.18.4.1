namespace Task._18._4._1
{
    class DownloadCommand : Command
    {
        DowloadYoutubeVideo download;

        public DownloadCommand(DowloadYoutubeVideo d)
        {
            download = d;
        }
        public override void Execute(string url)
        {
            _ = download.StartDowloadYoutubeVideoAsync(url);
        }

        public override void Undo()
        { }
    }
}
