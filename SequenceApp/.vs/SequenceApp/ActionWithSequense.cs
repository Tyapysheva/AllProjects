namespace SequenceApp
{
    public class ActionWithSequense
    {

        private static string sequenceInput = "";

        public static string InputSring()
        {
            while (sequenceInput == null || sequenceInput.Equals(""))
            {
                Console.WriteLine("Input sequence\r");
                sequenceInput = "" + Console.ReadLine();
            }
            return sequenceInput.ToLower();
        }

        public static int CalculateUniqueSequense(string text)
        {
            int current = 1;
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
                        current = 1;
                    }
                }
                else if (text.Length == 1)
                {
                    current = 1;
                }

                if (max < current)
                {
                    max = current;
                }

            }
            return max;
        }

        public static int CalculateRepetedSequense(string text)
        {
            
            int current = 1;
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length - 1 != i)
                {
                    if (text[i].Equals(text[i + 1]) && (text[i] >= 'a' && text[i] <= 'z'))
                    {
                        current++;
                    }

                    else
                    {
                        current = 1;
                    }
                }
                else if (text.Length == 1)
                {
                    current = 1;
                }

                if (max < current)
                {
                    max = current;
                }

            }
            return max;

        }

        public static int CalculateRepetedNumberSequense(string text)
        {
            int current = 1;
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length - 1 != i)
                {
                    if (text[i].Equals(text[i + 1]) && (text[i] >= '0' && text[i] <= '9'))
                    {
                        current++;
                    }
                    else
                    {
                        current = 1;
                    }
                }
                else if (text.Length == 1)
                {
                    current = 1;
                }
                else
                {
                    current = 0;
                }

                if (max < current)
                {
                    max = current;
                }

            }
            return max;

        }
    }
}
