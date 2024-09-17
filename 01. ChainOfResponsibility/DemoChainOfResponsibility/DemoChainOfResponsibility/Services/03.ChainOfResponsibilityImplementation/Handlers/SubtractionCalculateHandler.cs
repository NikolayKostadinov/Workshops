namespace DemoChainOfResponsibility.Services._03.ChainOfResponsibilityImplementation.Handlers;

public class SubtractionCalculateHandler: CalculateHandler
{
    protected override bool CanHandle(OperationState operationState)
    {
        return operationState.Operation == "-";
    }

    protected override decimal Handle(OperationState operationState)
    {
        return operationState.First - operationState.Second;
    }
}
