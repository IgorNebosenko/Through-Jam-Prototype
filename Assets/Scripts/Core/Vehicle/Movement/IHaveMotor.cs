namespace ElectrumGames.Core.Vehicle.Movement
{
    public interface IHaveMotor
    {
        void AddVelocity(float force, float deltaTime);
    }
}