namespace InfoAuto.AutoInfo
{
    public class Auto
    {
        private string carMake;
        private string model;
        private int quantity;
        private double costForUnit;

        public Auto(string carMake, string model, int quantity, double costForUnit)
        {
            CarMake = carMake;
            Model = model;
            Quantity = quantity;
            CostForUnit = costForUnit;
        }

        public string CarMake { get => carMake; set => carMake = value; }
        public string Model { get => model; set => model = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double CostForUnit { get => costForUnit; set => costForUnit = value; }


    }
}
