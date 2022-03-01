namespace Task._18._4._1
{
    abstract class Command
    {
        public abstract void Execute(string url);
        public abstract void Undo();
    }
}
