namespace StrategyPattern.Strategies.Interfaces
{
    public interface INumbersStrategy
    {
        int Execute(params int[] numbers);
    }
}
