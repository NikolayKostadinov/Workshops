namespace DemoChainOfResponsibility.Services._03.ChainOfResponsibilityImplementation;

using Handlers;

public class CalculateHandlerFactory
{
    public ICalculateHandler GetHandler()
    {
        var additionHandler = new AdditionCalculateHandler();
        var subtractionHandler = new SubtractionCalculateHandler();
        var multiplicationHandler = new MultiplicationCalculateHandler();
        var divisionHandler = new DivisionCalculateHandler();
        var modulusHandler = new ModulusCalculateHandler();

        additionHandler.SetSuccessor(subtractionHandler);
        subtractionHandler.SetSuccessor(multiplicationHandler);
        multiplicationHandler.SetSuccessor(divisionHandler);
        divisionHandler.SetSuccessor(modulusHandler);
        return additionHandler;
    }
}
