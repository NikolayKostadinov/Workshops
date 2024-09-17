namespace DemoChainOfResponsibility.Services._03.ChainOfResponsibilityImplementation;

public interface ICalculateHandler: ICalculatorService
{
    void SetSuccessor(ICalculateHandler calculateHandler);
}
