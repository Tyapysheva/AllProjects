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
            return sequenceInput;
        }

        public static int CalculateUniqueSequense(string text)
        {
            int current = 1;
            int max = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
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

            }
            else
            {
                current = 0;
            }
                return max;
        }

        public static int CalculateRepetedSequense(string text)
        {
            text = text.ToLower();
            int current = 1;
            int max = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length - 1 != i && (text[i] >= 'a' && text[i] <= 'z'))
                    {
                        if (text[i].Equals(text[i + 1]))
                        {
                            current++;
                        }
                        else
                        {
                            current = 1;
                        }
                    }
                    else if (!(text[i] >= 'a' && text[i] <= 'z'))
                    {
                        current = 0;
                    }
                    else if (text.Length == 1 && (text[i] >= 'a' && text[i] <= 'z'))
                    {
                        current = 1;
                    }
                    if (max < current)
                    {
                        max = current;
                    }
                }
            }
            else
            {
                current = 0;
            }
            return max;
        }

        public static int CalculateRepetedNumberSequense(string text)
        {
            int current = 1;
            int max = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length - 1 != i && (text[i] >= '0' && text[i] <= '9'))
                    {
                        if (text[i].Equals(text[i + 1]))
                        {
                            current++;
                        }
                        else
                        {
                            current = 1;
                        }
                    }
                    else if (!(text[i] >= '0' && text[i] <= '9'))
                    {
                        current = 0;
                    }
                    else if (text.Length == 1 && (text[i] >= '0' && text[i] <= '9'))
                    {
                        current = 1;
                    }

                    if (max < current)
                    {
                        max = current;
                    }
                }

            }
            else
            {
                current = 0;
            }
            return max;

        }
    }
}
