namespace ComputerSystem
{
    using System;
    using System.Threading;

    public class RestartCommand : Command
    {
        public RestartCommand(ControlPanel panel)
            : base(panel)
        {
        }

        public override void Execute()
        {
            this.panel.Restart();
        }
    }
}
