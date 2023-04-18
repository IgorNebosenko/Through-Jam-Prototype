namespace ElectrumGames.Core.Vehicle.Movement
{
    public class MotorWithGuideWheel : WheelBase, ICanRotate, IHaveMotor
    {
        public void Rotate(float direction, float deltaTime)
        {
            throw new System.NotImplementedException();
        }

        public void AddVelocity(float force, float deltaTime)
        {
            throw new System.NotImplementedException();
        }
    }
}