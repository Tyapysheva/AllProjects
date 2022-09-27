using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoAuto.AutoInfo;
using InfoAuto.AutoInfoCommands.Interface;

namespace InfoAuto.AutoInfoCommands.Manager
{
    public class Register
    {
        private static CalculateAuto calculateAuto = new CalculateAuto();
        public static void RegisterCountTypesAuto(List<Auto> listAuto)
        {
            Command countTypesAuto = new CountTypesCommand(calculateAuto, listAuto);
            CommandManager.Instance()
                          .Register("countTypesAuto", countTypesAuto);
        }
        public static void RegisterAveragePriceAll(List<Auto> listAuto)
        {

            Command averagePriceAllCommand = new AveragePriceAllCommand(calculateAuto, listAuto);

            CommandManager.Instance()
                          .Register("averagePriceAll", averagePriceAllCommand);

        }
        public static void RegisterAveragePriceType(List<Auto> listAuto, string carMark)
        {
            Command averagePriceTypeCommand = new AveragePriceTypeCommand(calculateAuto, listAuto, carMark);
            CommandManager.Instance()
                          .Register("averagePriceType", averagePriceTypeCommand);

        }

        public static void RegisterCountAllAuto(List<Auto> listAuto)
        {
            Command countAllAuto = new CountAllAutoCommand(calculateAuto, listAuto);
            CommandManager.Instance()
                          .Register("countAllAuto", countAllAuto);
        }
    }
}
