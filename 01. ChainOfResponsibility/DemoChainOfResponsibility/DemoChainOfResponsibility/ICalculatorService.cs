namespace DemoChainOfResponsibility;

public interface ICalculatorService
{
    decimal HandleCalculate(decimal first, decimal second, string operation);
}
