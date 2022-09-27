using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoAuto.AutoInfo;
using InfoAuto.AutoInfoCommands.Interface;

namespace InfoAuto.AutoInfoCommands
{
    public class CountAllAutoCommand : Command
    {
        CalculateAuto command;
        List<Auto> list;

        public CountAllAutoCommand(CalculateAuto command, List<Auto> list)
        {
            this.command = command;
            this.list = list;
        }

        public void Execute()
        {
            Console.WriteLine(command.countAllAuto(list));
        }
    }
}
