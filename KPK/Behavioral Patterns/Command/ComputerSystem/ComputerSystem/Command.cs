namespace ComputerSystem
{
    public abstract class Command
    {
        protected readonly ControlPanel panel;

        public Command(ControlPanel panel)
        {
            this.panel = panel;
        }

        public abstract void Execute();
    }
}
