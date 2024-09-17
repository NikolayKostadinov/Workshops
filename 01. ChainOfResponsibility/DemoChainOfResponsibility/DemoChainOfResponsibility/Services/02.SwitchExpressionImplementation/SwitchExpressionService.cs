namespace DemoChainOfResponsibility.Services._02.SwitchExpressionImplementation;

public class SwitchExpressionService : ICalculatorService
{
    public decimal HandleCalculate(decimal first, decimal second, string operation)
    {
        return operation switch
        {
            "+" => first + second, // 1 + 2 = ?
            "-" => first - second, // 3 - 1 = ?
            "*" => first * second, // 2 * 3 = 6
            "/" => first / second, // 4 / 2 = 2
            _ => throw new AggregateException($"Unsupported operation {operation}")
        };
    }
}
