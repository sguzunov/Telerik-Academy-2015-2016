namespace ComputerSystem
{
    using System;

    public class Program
    {
        static void Main()
        {
            // Receiver
            var panel = new ControlPanel();

            // Command
            var restartCommand = new RestartCommand(panel);

            // invoker
            var computer = new Computer();

            computer.ExecuteCommand(restartCommand);
        }
    }
}
