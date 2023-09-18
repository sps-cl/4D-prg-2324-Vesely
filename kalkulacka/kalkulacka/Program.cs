using kalkulacka.Operation;

namespace kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorContext context = new CalculatorContext(new OperationAdd());
            Console.WriteLine($"4 + 5 = {context.executeOperation(4,5)}");
        }
    }
}