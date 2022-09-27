namespace NumeralSystem
{
    class ConsoleActions
    {

        public int InputNumber()
        {
            int number;
            bool success;
            Console.WriteLine("Enter a decimal integer");
            string inputString = Console.ReadLine();
            success = int.TryParse(inputString, out number);
            while (!success)
            {
                Console.WriteLine("It is not a decimal integer");
                inputString = Console.ReadLine();
                success = int.TryParse(inputString, out number);
            }
            return number;
        }

        public int InputNumeralSystem()
        {
            int numeralSystemNumber;
            bool success;
            Console.WriteLine("Enter a numeral system from 2 to 20");
            string inputString = Console.ReadLine();
            success = int.TryParse(inputString, out numeralSystemNumber);
            while (numeralSystemNumber < 2 || numeralSystemNumber > 20 || !success)
            {
                Console.WriteLine("It is not a numeral system");
                inputString = Console.ReadLine();
                success = int.TryParse(inputString, out numeralSystemNumber);
            }
            return numeralSystemNumber;
        }

        public string ConvertDecimalIntToNumeralSystem(int number, int numeralSystemNumber)
        {
            string result = "";
            List<char> buffer = new List<char>();
            do
            {
                int x = number % numeralSystemNumber;
                number = number / numeralSystemNumber;
                char z;
                if (x < 10)
                {
                    z = Convert.ToChar('0' + x);
                }
                else
                {
                    z = Convert.ToChar('A' - 10 + x);
                }
                buffer.Add(z);
            }
            while (number > 0);
            buffer.Reverse();
            buffer.ForEach(x => result = result + x);
            return result;
        }

    }

}