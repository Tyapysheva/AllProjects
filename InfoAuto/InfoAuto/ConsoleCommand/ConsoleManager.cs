using InfoAuto.AutoInfo;
using InfoAuto.AutoInfoCommands.Manager;

namespace InfoAuto.ConsoleCommand
{
    public class ConsoleManager
    {
        private List<Auto> listAuto = new List<Auto>();
        private int quantity;
        private double price;
        private bool success;
        private string carMake;
        private string model;
        private int expression;
        private Auto InputAutoParameter()
        {
            Console.WriteLine("Enter Auto");
            carMake = EnterCarMake();
            model = EnterModel();
            Console.WriteLine("Enter quantity");
            success = int.TryParse(Console.ReadLine(), out quantity);
            while (!success)
            {
                Console.WriteLine("It is not an integer");
                success = int.TryParse(Console.ReadLine(), out quantity);
            }

            Console.WriteLine("Enter price for unit");
            success = double.TryParse(Console.ReadLine(), out price);
            while (!success)
            {
                Console.WriteLine("It is not an integer");
                success = double.TryParse(Console.ReadLine(), out price);
            }
            return new Auto(carMake, model, quantity, price);
        }

        private string EnterCarMake()
        {
            Console.WriteLine("Enter name car make");
            carMake = Console.ReadLine();
            while (carMake == null || carMake.Equals(""))
            {
                Console.WriteLine("Enter car make");
                carMake = Console.ReadLine();
            }
            return carMake;
        }

        private string EnterModel()
        {
            Console.WriteLine("Enter model");
            model = Console.ReadLine();
            while (model == null || model.Equals(""))
            {
                Console.WriteLine("Enter model");
                model = Console.ReadLine();
            }
            return model;
        }

        public void Menu()
        {
            listAuto.Add(InputAutoParameter());
            var flag = false;

            while (!flag)
            {
                Console.WriteLine("Enter command:\n" +
               "\"1. addAuto\"\n" +
               "\"2. averagePriceAll\"\n" +
               "\"3. averagePriceType\"\n" +
               "\"4. countAllAuto\"\n" +
               "\"5. countTypesAuto\"\n" +
               "\"6. exit\"");
                success = int.TryParse(Console.ReadLine(), out expression);
                switch (expression)
                {
                    case 1:
                        listAuto.Add(InputAutoParameter());
                        break;
                    case 2:
                        Register.RegisterAveragePriceAll(listAuto);
                        CommandManager.Instance()
                            .Execute("averagePriceAll");
                        break;
                    case 3:
                        EnterCarMake();
                        Register.RegisterAveragePriceType(listAuto, carMake);
                        CommandManager.Instance()
                            .Execute("averagePriceType");
                        break;
                    case 4:
                        Register.RegisterCountAllAuto(listAuto);
                        CommandManager.Instance()
                            .Execute("countAllAuto");
                        break;
                    case 5:
                        Register.RegisterCountTypesAuto(listAuto);
                        CommandManager.Instance()
                            .Execute("countTypesAuto");
                        break;

                    case 6:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("You entered the wrong command");
                        break;
                }
            }
        }
    }
}
