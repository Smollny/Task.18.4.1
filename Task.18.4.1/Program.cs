using System;

namespace Task._18._4._1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите URL видео: ");
            var url = Console.ReadLine();

            // инициатор команды
            Invoker invoker = new Invoker();
            
            // получатель команды на получение данных о видео
            GetInfoYoutubeVideo getInfo = new GetInfoYoutubeVideo();

            // команда на получение данных о видео
            GetInfoCommand getInfoCommand = new GetInfoCommand(getInfo);
            invoker.SetCommand(getInfoCommand);
            invoker.Run(url);

            // получатель команды на скачивание видео
            DowloadYoutubeVideo dowload = new DowloadYoutubeVideo();

            // команда на скачивание видео
            DownloadCommand downloadCommand = new DownloadCommand(dowload);
            invoker.SetCommand(downloadCommand);
            invoker.Run(url);

            Console.ReadKey();
        }
    }
}
