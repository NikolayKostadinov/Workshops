namespace DemoChainOfResponsibility.Services._01.ClassicIfThenElseImplementation;

public class ClassicIfThenElseService : ICalculatorService
{
    public decimal HandleCalculate(decimal first, decimal second, string operation)
    {
        decimal result;

        if (operation == "+") // 1 + 2 = ?
        {
            result = first + second;
        }
        else if (operation == "-") // 3 - 1 = ?
        {
            result = first - second;
        }
        else if (operation == "*") // 2 * 3 = 6
        {
            result = first * second;
        }
        else if (operation == "/") // 4 / 2 = 2
        {
            result = first / second;
        }
        else
        {
            throw new AggregateException($"Unsupported operation {operation}");
        }

        return result;
    }
}
