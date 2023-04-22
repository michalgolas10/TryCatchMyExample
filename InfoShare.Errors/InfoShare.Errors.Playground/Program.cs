namespace InfoShare.Errors.Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic calculator calculates magic number ;)");
            Console.Write("Please enter seed number (0 - 100): ");

            var seed = int.Parse(Console.ReadLine());

            var magicCalculator = new MagicCalculator();
            var result = magicCalculator.CalculateMagicNumber(seed);

            Console.WriteLine($"Magic number for seed {seed} is {result}");
        }
    }
}