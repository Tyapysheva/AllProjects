using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoAuto.AutoInfo;
using InfoAuto.AutoInfoCommands.Interface;

namespace InfoAuto.AutoInfoCommands
{
    public class CountTypesCommand : Command
    {
        private AutoAccounting command;
        private List<Auto> list;

        public CountTypesCommand(AutoAccounting command, List<Auto> list)
        {
            this.command = command;
            this.list = list;
        }

        public void Execute()
        {
            Console.WriteLine(command.CountTypesAuto(list));
        }
    }
}
