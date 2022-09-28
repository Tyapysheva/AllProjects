using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoAuto.AutoInfo;
using InfoAuto.AutoInfoCommands.Interface;

namespace InfoAuto.AutoInfoCommands.Manager
{
    public class CommandRegister
    {
        private static AutoAccounting autoAccounting = new AutoAccounting();
        public static void RegisterCountTypesAuto(List<Auto> listAuto)
        {
            Command countTypesAuto = new CountTypesCommand(autoAccounting, listAuto);
            CommandManager.Instance()
                          .Register("CountTypesAuto", countTypesAuto);
        }
        public static void RegisterAveragePriceAll(List<Auto> listAuto)
        {

            Command averagePriceAllCommand = new AveragePriceAllCommand(autoAccounting, listAuto);

            CommandManager.Instance()
                          .Register("averagePriceAll", averagePriceAllCommand);

        }
        public static void RegisterAveragePriceType(List<Auto> listAuto, string carMark)
        {
            Command averagePriceTypeCommand = new AveragePriceTypeCommand(autoAccounting, listAuto, carMark);
            CommandManager.Instance()
                          .Register("averagePriceType", averagePriceTypeCommand);

        }

        public static void RegisterCountAllAuto(List<Auto> listAuto)
        {
            Command countAllAuto = new CountAllAutoCommand(autoAccounting, listAuto);
            CommandManager.Instance()
                          .Register("CountAllAuto", countAllAuto);
        }
    }
}
