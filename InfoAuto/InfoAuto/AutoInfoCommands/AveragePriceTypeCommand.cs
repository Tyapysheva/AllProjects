using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoAuto.AutoInfo;
using InfoAuto.AutoInfoCommands.Interface;

namespace InfoAuto.AutoInfoCommands
{
    public class AveragePriceTypeCommand : Command
    {
        CalculateAuto command;
        List<Auto> list;
        string carMark;

        public AveragePriceTypeCommand(CalculateAuto command, List<Auto> list, string carMark)
        {
            this.command = command;
            this.list = list;
            this.carMark = carMark;
        }

        public void Execute()
        {
            Console.WriteLine(command.countAveragePriceAuto(list, carMark));
        }
    }
}
