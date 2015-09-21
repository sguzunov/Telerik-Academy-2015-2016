namespace ComputerSystem
{
    public class Computer
    {
        public void ExecuteCommand(Command command)
        {
            command.Execute();
        }
    }
}
