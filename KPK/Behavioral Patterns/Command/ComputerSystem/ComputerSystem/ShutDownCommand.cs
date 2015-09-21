namespace ComputerSystem
{
    public class ShutDownCommand : Command
    {
        public ShutDownCommand(ControlPanel panel)
            : base(panel)
        {
        }

        public override void Execute()
        {
            this.panel.ShutDown();
        }
    }
}
