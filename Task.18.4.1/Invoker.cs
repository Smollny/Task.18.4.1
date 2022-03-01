namespace Task._18._4._1
{
    class Invoker
    {
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Run(string url)
        {
            command.Execute(url);
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
}
