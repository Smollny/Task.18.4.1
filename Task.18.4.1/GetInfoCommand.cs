using System;

namespace Task._18._4._1
{
    class GetInfoCommand : Command
    {
        GetInfoYoutubeVideo getInfo;

        public GetInfoCommand(GetInfoYoutubeVideo g)
        {
            getInfo = g;
        }

        public override void Execute(string url)
        {
            _ = getInfo.GetInfoYoutubeVideoAsync(url);
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
