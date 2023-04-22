using System.Threading.Channels;

namespace InfoShare.Errors.Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic calculator calculates magic number ;)");
            Console.Write("Please enter seed number (0 - 100): ");
            var magicCalculator = new MagicCalculator();
            try
            {
                int.TryParse(Console.ReadLine(),out var seed);
                var result = magicCalculator.CalculateMagicNumber(seed);
                Console.WriteLine($"Magic number for seed {seed} is {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Mordo źle wpisałeś coś");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument exception");
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Invalid operation excp");
            }
            catch(NotImplementedException)
            {
                Console.WriteLine("Notimplremensadsdasd");
            }
            finally
            {
                magicCalculator.Close();
            }
        }
    }
}