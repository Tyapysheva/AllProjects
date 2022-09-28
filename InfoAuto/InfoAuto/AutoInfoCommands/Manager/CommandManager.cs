using InfoAuto.AutoInfoCommands.Interface;

namespace InfoAuto.AutoInfoCommands.Manager
{
    public class CommandManager
    {
        private Dictionary<string, Command> commandMap = new Dictionary<string, Command>();

        private static CommandManager instance;
        public string value;

        private CommandManager()
        {

        }
        public static CommandManager Instance()
        {
            if (instance == null)
            {
                instance = new CommandManager();
            }
            return instance;
        }


        public void Register(string commandName, Command command)
        {
            commandMap.Add(commandName, command);
        }

        public void Execute(string commandName)
        {
            Command command = commandMap[commandName];
            if (command == null)
            {
                throw new Exception("no command registered for " + commandName);
            }
            command.Execute();
        }
    }

}
