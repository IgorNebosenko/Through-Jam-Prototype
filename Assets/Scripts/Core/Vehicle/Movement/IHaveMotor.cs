namespace ElectrumGames.Core.Vehicle.Movement
{
    public interface IHaveMotor
    {
        void AddVelocity(float direction, float deltaTime);
    }
}