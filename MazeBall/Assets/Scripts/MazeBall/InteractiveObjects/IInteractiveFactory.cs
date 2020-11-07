using Main;

namespace MazeBall
{
    public interface IInteractiveFactory
    {
        IInteractive CreateInteractive(InterectiveObjectType type);
    }
}