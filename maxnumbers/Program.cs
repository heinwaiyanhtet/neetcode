namespace MaxProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = FindMaxValue(new int[] { 1, 2, 3, 4, 5 });

            Console.WriteLine(maxValue);
        }

        static int FindMaxValue(int[] numbers)
        {
            int maxValue = int.MinValue;

            foreach (var item in numbers)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }
    }   
}