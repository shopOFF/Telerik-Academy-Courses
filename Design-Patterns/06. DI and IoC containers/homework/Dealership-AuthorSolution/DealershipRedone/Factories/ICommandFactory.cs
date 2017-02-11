using Dealership.Engine;

namespace DealershipRedone.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string input);
    }
}
