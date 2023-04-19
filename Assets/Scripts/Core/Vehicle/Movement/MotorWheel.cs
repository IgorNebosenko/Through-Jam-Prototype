using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class MotorWheel : WheelBase, IHaveMotor
    {
        [SerializeField] private float forceMove = 100;

        public void AddVelocity(float direction, float deltaTime)
        {
            wheel.motorTorque = forceMove * direction * deltaTime;
        }
    }
}