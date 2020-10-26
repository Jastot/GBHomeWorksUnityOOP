namespace Main
{
    public interface Iinteractive : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }
}
    