namespace DemoChainOfResponsibility;

using Services._01.ClassicIfThenElseImplementation;
using Services._02.SwitchExpressionImplementation;
using Services._03.ChainOfResponsibilityImplementation;

public static class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine() ?? "";
        var operands = input.Split(" ");
        var first = decimal.Parse(operands[0]);
        var second = decimal.Parse(operands[2]);
        var operation = operands[1];
        var result = CalculateResult(first, second, operation);
        Console.WriteLine(result);
    }

    // public static decimal CalculateResult(decimal first, decimal second, string operation)
    // {
    //     ICalculatorService service = new ClassicIfThenElseService();
    //     var result = service.HandleCalculate(first, second, operation);
    //     return result;
    // }

    // Switch implementation
    // public static decimal CalculateResult(decimal first, decimal second, string operation)
    // {
    //     ICalculatorService service = new SwitchExpressionService();
    //     var result = service.HandleCalculate(first, second, operation);
    //     return result;
    // }

    public static decimal CalculateResult(decimal first, decimal second, string operation)
    {
        var factory = new CalculateHandlerFactory();
        ICalculatorService service = factory.GetHandler();
        var result = service.HandleCalculate(first, second, operation);
        return result;
    }
}
