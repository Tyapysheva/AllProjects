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
            int currentLengthSequense = 1;
            int maximumLengthSequense = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length - 1 != i)
                    {
                        if (!text[i].Equals(text[i + 1]))
                        {
                            currentLengthSequense++;
                        }
                        else
                        {
                            currentLengthSequense = 1;
                        }
                    }
                    else if (text.Length == 1)
                    {
                        currentLengthSequense = 1;
                    }
                    if (maximumLengthSequense < currentLengthSequense)
                    {
                        maximumLengthSequense = currentLengthSequense;
                    }
                }
            }
            else
            {
                currentLengthSequense = 0;
            }
                return maximumLengthSequense;
        }
        public static int CalculateRepetedSequense(string text)
        {
            text = text.ToLower();
            int currentLengthSequense = 1;
            int maximumLengthSequense = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length - 1 != i && (text[i] >= 'a' && text[i] <= 'z'))
                    {
                        if (text[i].Equals(text[i + 1]))
                        {
                            currentLengthSequense++;
                        }
                        else
                        {
                            currentLengthSequense = 1;
                        }
                    }
                    else if (!(text[i] >= 'a' && text[i] <= 'z'))
                    {
                        currentLengthSequense = 0;
                    }
                    else if (text.Length == 1 && (text[i] >= 'a' && text[i] <= 'z'))
                    {
                        currentLengthSequense = 1;
                    }
                    if (maximumLengthSequense < currentLengthSequense)
                    {
                        maximumLengthSequense = currentLengthSequense;
                    }
                }
            }
            else
            {
                currentLengthSequense = 0;
            }
            return maximumLengthSequense;
        }
        public static int CalculateRepetedNumberSequense(string text)
        {
            int currentLengthSequense = 1;
            int maximumLengthSequense = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length - 1 != i && (text[i] >= '0' && text[i] <= '9'))
                    {
                        if (text[i].Equals(text[i + 1]))
                        {
                            currentLengthSequense++;
                        }
                        else
                        {
                            currentLengthSequense = 1;
                        }
                    }
                    else if (!(text[i] >= '0' && text[i] <= '9'))
                    {
                        currentLengthSequense = 0;
                    }
                    else if (text.Length == 1 && (text[i] >= '0' && text[i] <= '9'))
                    {
                        currentLengthSequense = 1;
                    }
                    if (maximumLengthSequense < currentLengthSequense)
                    {
                        maximumLengthSequense = currentLengthSequense;
                    }
                }
            }
            else
            {
                currentLengthSequense = 0;
            }
            return maximumLengthSequense;
        }
    }
}
