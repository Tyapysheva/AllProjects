namespace SequenceApp
{
    class ActionWithSequense
    {

        private static string sequenceInput = "";

        public static string InputSring()
        {
            while (sequenceInput == null || sequenceInput.Equals(""))
            {
                Console.WriteLine("Input sequence\r");
                sequenceInput = "" + Console.ReadLine();
            }
            return sequenceInput;
        }

        public static void CalculateUnitSequense(string text)
        {
            int current = 0;
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {

                if (text.Length - 1 != i)
                {
                    if (!text[i].Equals(text[i + 1]))
                    {
                        current++;
                    }
                    else
                    {
                        current = 0;
                    }
                }
                else if (text.Length == 1 || text[text.Length - 1] != text[text.Length - 2])
                {
                    current++;
                    Console.WriteLine(text[text.Length - 1]);
                }

                if (max < current)
                {
                    max = current;
                }

            }


            Console.WriteLine("\n" + max);

        }
    }

}

