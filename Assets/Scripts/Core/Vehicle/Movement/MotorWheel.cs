using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class MotorWheel : WheelBase, IHaveMotor
    {
        [SerializeField] private float forceMove;

        public void AddVelocity(float direction, float deltaTime)
        {
            wheel.motorTorque = forceMove * direction * deltaTime;
        }
    }
}