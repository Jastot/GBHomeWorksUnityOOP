namespace MazeBall
{
    public interface ILateExecute: IController
    {
        void LateExecute(float deltaTime);
    }
}