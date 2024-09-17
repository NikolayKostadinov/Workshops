namespace DemoChainOfResponsibility.Services._03.ChainOfResponsibilityImplementation;

public abstract class CalculateHandler: ICalculateHandler
{
    private ICalculateHandler? _successor;
    public decimal HandleCalculate(decimal first, decimal second, string operation)
    {
        var operationState = new OperationState(first, second, operation);

        if (CanHandle(operationState))
        {
            return Handle(operationState);
        }

        if (_successor is not null)
        {
            return _successor.HandleCalculate(first, second, operation);
        }

        throw new AggregateException($"Unsupported operation {operation}");
    }

    public void SetSuccessor(ICalculateHandler calculateHandler)
    {
        _successor = calculateHandler;
    }

    protected abstract bool CanHandle(OperationState operationState);

    protected abstract decimal Handle(OperationState operationState);
}

public class OperationState
{
    public OperationState(decimal first, decimal second, string operation)
    {
        First = first;
        Second = second;
        Operation = operation;
    }

    public decimal First { get; init; }
    public decimal Second { get; init; }
    public string Operation { get; init; }
}
