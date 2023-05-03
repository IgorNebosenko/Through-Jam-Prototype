namespace ElectrumGames.Core.Vehicle.Movement
{
    public interface ICanRotate
    {
        void Rotate(float deltaTime, float direction);
    }
}