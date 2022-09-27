using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfoAuto.AutoInfo
{
    public class CalculateAuto
    {
        public int countTypesAuto(List<Auto> autoList)
        {
            return autoList.Select(car => car.CarMake).Distinct().Count();
        }

        public int countAllAuto(List<Auto> autoList)
        {
            return autoList.Select(car => car.Quantity).Sum();
        }

        public double countAveragePriceAll(List<Auto> autoList)
        {
            double totalPrice = autoList.Select(x => x.Quantity * x.CostForUnit).Sum();

            double totalQuantity = autoList.Select(car => car.Quantity).Sum();

            return totalPrice / totalQuantity;
        }

        public double countAveragePriceAuto(List<Auto> autoList, string carMakeInput)
        {
            if (autoList.FindAll(car => car.CarMake.Equals(carMakeInput)).Count() != 0)
            {
                double totalPrice = autoList.Where(car => car.CarMake.Equals(carMakeInput))
                    .Select(car => car.Quantity * car.CostForUnit).Sum();
                double totalQuantity = autoList.Select(car => car.Quantity).Sum();
                return totalPrice / totalQuantity;

            }
            else
            {
                throw new ContainsException($"List doesn't contains car make = {carMakeInput}");
            }

        }
    }
}
