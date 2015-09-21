namespace ComputerSystem
{
    public class SleepCommand : Command
    {
        public SleepCommand(ControlPanel panel)
            : base(panel)
        {
        }

        public override void Execute()
        {
            this.panel.Sleep();
        }
    }
}
