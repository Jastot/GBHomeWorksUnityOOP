using Main;
using UnityEngine;

namespace MazeBall
{
    public interface IInteractiveFactory
    {
        //IInteractive CreateInteractive(InterectiveObjectType type);
        GameObject CreateInteractiveFromMass(int variable);
    }
}