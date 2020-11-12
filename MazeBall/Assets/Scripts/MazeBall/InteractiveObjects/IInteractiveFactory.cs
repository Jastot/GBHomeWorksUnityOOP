using Main;

namespace MazeBall
{
    public interface IInteractiveFactory
    {
        IInteractive CreateInteractive(InterectiveObjectType type);
        IInteractive CreateInteractiveFromMass(int variable);
    }
}