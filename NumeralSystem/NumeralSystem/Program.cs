namespace NumeralSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleActions consoleInput = new ConsoleActions();
            string result = consoleInput
                .ConvertDecimalIntToNumeralSystem(consoleInput.InputNumber(), 
                consoleInput.InputNumeralSystem());
            Console.WriteLine("\nResult = " + result);

        }
    }
}