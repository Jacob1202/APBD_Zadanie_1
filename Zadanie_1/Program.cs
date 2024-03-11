namespace Zadanie_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            List<int> valuesList = new List<int>() { 1, 2, 3, 4, 5, 6, };

            valuesList.ForEach(x  => Console.WriteLine(x+2));
        }

        public static double CountAverage(List<int> values)
        {
            return values.Average();
        }

        public static int CountMax(List<int> values)
        {
            return values.Max();
        }
    }
}